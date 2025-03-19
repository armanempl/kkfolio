using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Netcode;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using Unity.Services.Relay;
using Unity.Services.Relay.Models;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class LobbyManager : MonoBehaviour
{
      private string _lobbyId;
      private RelayHostData _hostData;
      private RelayJoinData _joinData;
      //public string lobbyCode;
      public TMP_InputField InputField;

    //Aktualizacja stanu
    public UnityAction<string> UpdateState;
    public UnityAction<string> StatePlayers;
    public UnityAction MatchFound;

    // Start is called before the first frame update
    public static LobbyManager _instance;
    public static LobbyManager Instance => _instance;
    public GameObject Menu;
    private void Awake() {
        //singleton - wzorzec projektowy
        if (_instance is null) {
            _instance = this;
            return;
        }
        Destroy(this);
    }

    async void Start()
    {

        //Inicjalizacja Unity Relay i Lobby
       await UnityServices.InitializeAsync(); 

        //nasłuchiwanie zdarzeń
       SetupEvents();

       await SignInAnonymouslyAsync();

        //Subskrypcja do zdarzeń NetworkManagera
        NetworkManager.Singleton.OnClientConnectedCallback += ClientConnected;
    }

    #region Network events
    private void ClientConnected(ulong id) {
        Debug.Log("Dołączył gracz o id: " + id);

        StatePlayers?.Invoke("Znaleziono gracza o id: " + id);
        MatchFound?.Invoke();
    }
    #endregion


#region UnityLogin

    // Update is called once per frame
    void SetupEvents()
    {
        AuthenticationService.Instance.SignedIn += () => {
            //otrzymanie playerID
            Debug.Log($"Identyfikator gracza: {AuthenticationService.Instance.PlayerId}");
            //otrzymanie token dostępu
            Debug.Log($"Token dostępu: {AuthenticationService.Instance.AccessToken}");
        };
    AuthenticationService.Instance.SignInFailed += (err) => {
        Debug.LogError(err);
    };
    AuthenticationService.Instance.SignedOut += () => {
        Debug.Log("Gracz wylogował się.");
    };
    }
    async Task SignInAnonymouslyAsync() {
        try {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
            Debug.Log("Zalogowano pomyślnie");
        } catch (Exception ex) {
            Debug.LogException(ex);
        }
        
    }

#endregion

#region Lobby  
    public async void FindMatch() {
        Debug.Log("Szukanie lobby...");
        UpdateState?.Invoke("Szukanie lobby...");
        try {
            //Tu chyba się wyszukuje lobby

            QuickJoinLobbyOptions options = new QuickJoinLobbyOptions();
            
            //Losowe lobby (chyba)
            Lobby lobby = await Lobbies.Instance.QuickJoinLobbyAsync(options);

            Debug.Log("Dołączono do lobby: " + lobby.Id);
            Debug.Log("Ilość graczy w lobby: " + lobby.Players.Count);

            //RelayCode
            string joinCode = lobby.Data["joinCode"].Value;
            Debug.Log("Kod dostępu: " + joinCode);
            JoinAllocation allocation = await Relay.Instance.JoinAllocationAsync(joinCode);

            //obiekt joindata
            _joinData = new RelayJoinData {
                Key = allocation.Key,
                Port = (ushort) allocation.RelayServer.Port,
                AllocationID = allocation.AllocationId,
                AllocationIDBytes = allocation.AllocationIdBytes,
                ConnectionData = allocation.ConnectionData,
                HostConnectionData = allocation.HostConnectionData,
                IPv4Address = allocation.RelayServer.IpV4
            };
            _joinData.JoinCode = await Relay.Instance.GetJoinCodeAsync(allocation.AllocationId);
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(
                _joinData.IPv4Address,
                _joinData.Port,
                _joinData.AllocationIDBytes,
                _joinData.Key,
                _joinData.ConnectionData,
                _joinData.HostConnectionData
            );

            NetworkManager.Singleton.StartClient();

            //Aktualizacja zdarzeń do tekstu
            UpdateState?.Invoke("Znaleziono lobby, dołączanie, kod dostępu: " + joinCode + ", ilość graczy: " + lobby.Players.Count);

            MatchFound?.Invoke();

        } catch (LobbyServiceException e) {
            //Jeżeli nie znalazło, tworzy nowe
            Debug.Log("Nie znaleziono lobby, spróbuj utworzyć nowe i zaprosić graczy" + e);
            UpdateState?.Invoke("Nie znaleziono lobby, spróbuj utworzyć  i zaprosić graczy");            
        }
    }

    public async void JoinByCode() {
        string lobbyCode = InputField.text;
        Debug.Log(lobbyCode);           
        Debug.Log("Szukanie lobby z wykorzystaniem kodu " + lobbyCode + "...");
        // UpdateState ?.Invoke("Szukanie lobby z wykorzystaniem kodu " + lobbyCode + "...");
        try {
            //Tu chyba się wyszukuje lobby

           JoinLobbyByCodeOptions options = new JoinLobbyByCodeOptions();
            //JoinByCodeRequest options = new JoinByCodeRequest(lobbyCode);
            //Losowe lobby (chyba)
            
            Lobby lobby = await Lobbies.Instance.JoinLobbyByCodeAsync(lobbyCode, options);
            Debug.Log(lobby);
            Debug.Log("Dołączono do lobby: " + lobby.Id);
            Debug.Log("Ilość graczy w lobby: " + lobby.Players.Count);

            //RelayCode
            string joinCode = lobby.Data["joinCode"].Value;           
            Debug.Log("Kod dostępu: " + joinCode);
            JoinAllocation allocation = await Relay.Instance.JoinAllocationAsync(joinCode);

             //obiekt joindata
             _joinData = new RelayJoinData {
                 Key = allocation.Key,
                 Port = (ushort) allocation.RelayServer.Port,
                AllocationID = allocation.AllocationId,
                AllocationIDBytes = allocation.AllocationIdBytes,
                ConnectionData = allocation.ConnectionData,
                HostConnectionData = allocation.HostConnectionData,
                IPv4Address = allocation.RelayServer.IpV4
            };

            _joinData.JoinCode = await Relay.Instance.GetJoinCodeAsync(allocation.AllocationId);

            NetworkManager.Singleton.GetComponent<UnityTransport>().SetClientRelayData(
                _joinData.IPv4Address,
                _joinData.Port,
                _joinData.AllocationIDBytes,
                _joinData.Key,
                _joinData.ConnectionData,
                _joinData.HostConnectionData
            );

            NetworkManager.Singleton.StartClient();

            
            //Aktualizacja zdarzeń do tekstu
            Debug.Log("Znaleziono lobby, kod: " + joinCode);
            UpdateState?.Invoke("Znaleziono lobby, dołączanie, kod dostępu: " + joinCode + ", ilość graczy: " + lobby.Players.Count);
            MatchFound?.Invoke();

        } catch (LobbyServiceException e) {
            //Jeżeli nie znalazło, tworzy nowe
            Debug.Log("Nie znaleziono lobby, spróbuj utworzyć pokój i zaprosić graczy" + e);
        }
    }
    
    public async void CreateMatchPublic() {
        Debug.Log ("Tworzenie nowego publicznego lobby...");
        UpdateState?.Invoke("Tworzenie nowego publicznego lobby...");
        int maxConnections = 1;

        try {

            //obiekt Relay
            Allocation allocation = await Relay.Instance.CreateAllocationAsync(maxConnections);
            _hostData = new RelayHostData {
                Key = allocation.Key,
                Port = (ushort) allocation.RelayServer.Port,
                AllocationID = allocation.AllocationId,
                AllocationIDBytes = allocation.AllocationIdBytes,
                ConnectionData = allocation.ConnectionData,
                IPv4Address = allocation.RelayServer.IpV4
            };

            //join code
            _hostData.JoinCode = await Relay.Instance.GetJoinCodeAsync(allocation.AllocationId);

            string lobbyName = "game_lobby";
            int maxPlayers = 4;
            CreateLobbyOptions options = new CreateLobbyOptions();
            options.IsPrivate = false;

            options.Data = new Dictionary<string, DataObject>() {
                {
                    "joinCode",new DataObject(
                        visibility: DataObject.VisibilityOptions.Member,
                        value: _hostData.JoinCode
                    )
                }
            };

            var lobby = await Lobbies.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
            _lobbyId = lobby.Id;
            Debug.Log("Stworzono lobby: " + lobby.Id);
            StartCoroutine(HeartbeatLobbyCoroutine(lobby.Id, 15));
            string joinCode = lobby.Data["joinCode"].Value;
            Debug.Log("Kod dostępu: " + joinCode);
            //dane transportowe
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(
                _hostData.IPv4Address,
                _hostData.Port,
                _hostData.AllocationIDBytes,
                _hostData.Key,
                _hostData.ConnectionData
            );
            NetworkManager.Singleton.StartHost();

            UpdateState?.Invoke("Oczekiwanie na graczy, kod dostępu: " + joinCode + " , ilość graczy: " + lobby.Players.Count);

        }
        catch (LobbyServiceException e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public async void CreateMatchPrivate() {
        Debug.Log ("Tworzenie nowego prywatnego lobby...");
        UpdateState?.Invoke("Tworzenie nowego prywatnego lobby...");
        int maxConnections = 1;

        try {

            //obiekt Relay
            Allocation allocation = await Relay.Instance.CreateAllocationAsync(maxConnections);
            _hostData = new RelayHostData {
                Key = allocation.Key,
                Port = (ushort) allocation.RelayServer.Port,
                AllocationID = allocation.AllocationId,
                AllocationIDBytes = allocation.AllocationIdBytes,
                ConnectionData = allocation.ConnectionData,
                IPv4Address = allocation.RelayServer.IpV4
            };

            //join code
            _hostData.JoinCode = await Relay.Instance.GetJoinCodeAsync(allocation.AllocationId);

            string lobbyName = "game_lobby";
            int maxPlayers = 4;
            CreateLobbyOptions options = new CreateLobbyOptions();
            options.IsPrivate = true;

            options.Data = new Dictionary<string, DataObject>() {
                {
                    "joinCode",new DataObject(
                        visibility: DataObject.VisibilityOptions.Member,
                        value: _hostData.JoinCode
                    )
                }
            };

            var lobby = await Lobbies.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
            _lobbyId = lobby.Id;
            Debug.Log("Stworzono lobby: " + lobby.Id);
            StartCoroutine(HeartbeatLobbyCoroutine(lobby.Id, 15));
            string joinCode = lobby.Data["joinCode"].Value;
            Debug.Log("Kod dostępu: " + joinCode);
            //dane transportowe
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(
                _hostData.IPv4Address,
                _hostData.Port,
                _hostData.AllocationIDBytes,
                _hostData.Key,
                _hostData.ConnectionData
            );
            NetworkManager.Singleton.StartHost();

            UpdateState?.Invoke("Oczekiwanie na graczy, kod dostępu: " + joinCode + " , ilość graczy: " + lobby.Players.Count);

        }
        catch (LobbyServiceException e) {
            Console.WriteLine(e);
            throw;
        }
    }

    IEnumerator HeartbeatLobbyCoroutine(string lobbyId, float waitTimeSeconds) {
        var delay = new WaitForSecondsRealtime(waitTimeSeconds);
        while (true) {
            Lobbies.Instance.SendHeartbeatPingAsync(lobbyId);
            Debug.Log("Sprawdzenie działania lobby");
            yield return delay;
        }
    }


    private void OnDestroy() {
        //Usuwanie lobby kiedy jest niepotrzebne
        Lobbies.Instance.DeleteLobbyAsync(_lobbyId);
    }

#endregion

    public struct RelayHostData {
        public string JoinCode;
        public string IPv4Address;
        public ushort Port;
        public Guid AllocationID;
        public byte[] AllocationIDBytes;
        public byte[] ConnectionData;
        public byte[] Key;
    }

    public struct RelayJoinData {
        public string JoinCode;
        public string IPv4Address;
        public ushort Port;
        public Guid AllocationID;
        public byte[] AllocationIDBytes;
        public byte[] ConnectionData;
        public byte[] HostConnectionData;
        public byte[] Key;
    }
    }

