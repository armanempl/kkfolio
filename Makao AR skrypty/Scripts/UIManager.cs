using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private Text stateText;
    [SerializeField] private Text statePlayers;

    private void Start()
    {
        // Subscribe to events
        LobbyManager.Instance.MatchFound += MatchFound;
        LobbyManager.Instance.UpdateState += UpdateState;
        LobbyManager.Instance.StatePlayers += StatePlayers;        
    }

    private void UpdateState(string newState)
    {
        stateText.text = newState;

    }

    private void StatePlayers (string newState){
    statePlayers.text = newState;
    }
    private void MatchFound()
    {
        playButton.SetActive(false);
    }

    private void OnDestroy()
    {
        // Unsubscribe from events
        LobbyManager.Instance.MatchFound -= MatchFound;
        LobbyManager.Instance.UpdateState -= UpdateState;
        LobbyManager.Instance.StatePlayers -= StatePlayers;        
    }
}