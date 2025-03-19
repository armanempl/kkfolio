using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
public class DeckCardsTransform : MonoBehaviour
{
    // Animator _animator;
   // public Time deltaTime;
    public string CardSymbol;
    public string CardColor;
    public string CardType;
    public string CardSlot;
    public GameObject mid_card;
    public Transform mid_card_parent;
    public Transform old_mid_card;
    public Transform mid_card_child;
    public bool isComplete;
    public Transform CardStash;

    public Text HelpState;

    public GameObject Show_Colors;
    public GameObject Show_Joker_Colors;
    public GameObject Show_Chars;

    public GameObject Deck1;
    public GameObject Deck2;
    public GameObject Deck3;
    public GameObject Deck4;
    public bool stopQueue;
    public string ChosenColorAs;
    public GameObject Show_color_text;
    public TextMeshPro Change_color_text;
    
    public string ChosenColor;  
    public List<string> AceColors;
    public string oldMidCardSymbol;
    public string oldMidCardColor;
    public string oldMidCardType;
    public GameObject Panel1;
    public GameObject WinGame;
    public GameObject Gameobject;
    public List<string> randomCards2;
    public GameObject karta;

    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;


    //public static DeckCardsTransform _instance;
    //public static DeckCardsTransform Instance => _instance;

    string CheckCards(string CardSymbol, string CardColor)
    {
        string isCardSame;
        string diffmidCardSymbol = mid_card.transform.GetComponent<GetMidCardValue>().midCardSymbol.ToString();
        string diffmidCardColor = mid_card.transform.GetComponent<GetMidCardValue>().midCardColor.ToString();
        Debug.Log("Karta na środku: " + diffmidCardSymbol + " " + diffmidCardColor);
        if (CardSymbol == diffmidCardSymbol || diffmidCardColor == CardColor || CardColor == "1" || CardColor == "2")
        {
            isCardSame = "1";
            Debug.Log("Karty zgadzają się, można zagrać " + isCardSame);
            return isCardSame;
        }
        else
        {
            isCardSame = "0";

            Debug.Log("Karty nie zgadzają się, należy wziąć inną kartę " + isCardSame);
            return isCardSame;
        }
    }

    public void FunctionCards(string SelectedCardSymbol, string SelectedCardColor, string SelectedCardType, GameObject ClickedSlot)
    {
        stopQueue = false;
        Debug.Log(SelectedCardType);
        switch (SelectedCardType)
        {
            case "Zadanie":
                mid_card_child = mid_card.transform.GetChild(0);                
                mid_card_child.GetComponent<CardValues>().enabled = true;
    #region Zamiana kart       
  
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localScale = new Vector3(1f, 1f, 1f);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = false;                                                
                if (mid_card_child.GetComponent<CardValues>().enabled == false) {
                int RandomNumber = Random.Range(5,11);
                string DemandNumber = RandomNumber.ToString(); 
                mid_card_child.GetComponent<CardValues>().symbol = DemandNumber;                                                       
                }
                mid_card_child.GetComponent<CardValues>().cardType = "Zadanie";
                mid_card.GetComponent<GetMidCardValue>().midCardColor = mid_card_child.GetComponent<CardValues>().color;                                
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck2.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck2.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck2.GetComponent<Deck2CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Żądanie " + mid_card_child.GetComponent<CardValues>().symbol + " Kolejka gracza 2";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck2.GetComponent<CheckCards2>().enabled = true;            
        } 
    #endregion
    #endregion                 
                Debug.Log("Działanie karty żądania");
                //Show_Chars.SetActive(true);
                break;
            case "Wojenna":
                switch (SelectedCardSymbol)
                {
                    case "2":
                        int licznik = Gameobject.GetComponent<Dzialaj>().licznik;
                        randomCards2 = Gameobject.GetComponent<Dzialaj>().randomCards2;
                        for (int j = 0; j < 2; j++)
                        {
                            int ilosc_slotow = Panel2.transform.childCount;
                            for (int i = 0; i < ilosc_slotow; i++)
                            {
                                Transform slot = Panel2.transform.GetChild(i);
                                if (slot.transform.childCount == 0)
                                {
                                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[licznik]);
                                    karta.transform.SetParent(slot.transform);
                                    karta.transform.localPosition = new Vector3(0, 0, 0);
                                    karta.transform.localScale = new Vector3(33, 33, 1);

                                    break;
                                }
                            }
                            licznik++;
                        }
                        //Gracz 2 dobiera 2 karty
                        break;
                    case "3":
                        licznik = Gameobject.GetComponent<Dzialaj>().licznik;
                        randomCards2 = Gameobject.GetComponent<Dzialaj>().randomCards2;
                        for (int j = 0; j < 3; j++)
                        {
                            int ilosc_slotow = Panel2.transform.childCount;
                            for (int i = 0; i < ilosc_slotow; i++)
                            {
                                Transform slot = Panel2.transform.GetChild(i);
                                if (slot.transform.childCount == 0)
                                {
                                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[licznik]);
                                    karta.transform.SetParent(slot.transform);
                                    karta.transform.localPosition = new Vector3(0, 0, 0);
                                    karta.transform.localScale = new Vector3(33, 33, 1);

                                    break;
                                }
                            }
                            licznik++;
                        }
                        //Gracz 2 dobiera 3 karty
                        break;
                    case "Krol":
                    if (SelectedCardColor == "Pik" || SelectedCardColor == "Kier"){
                        // 5
                    }
                        break;
                }
    #region Zamiana kart            
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = true;
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck2.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck2.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck2.GetComponent<Deck2CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Kolejka gracza 2";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck2.GetComponent<CheckCards2>().enabled = true;            
        } 
    #endregion
    #endregion                 
                HelpState.text = "Następny gracz dobiera x kart";
                Debug.Log("Działanie karty wojennej");
                break;
            case "Zmiana":      
                mid_card_child = mid_card.transform.GetChild(0);                
                mid_card_child.GetComponent<CardValues>().enabled = true;                                                

    #region Zamiana kart       
  
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = false;                                                
                if (mid_card_child.GetComponent<CardValues>().enabled == false) {
                int RandomNumber = Random.Range(1,5);
                if (RandomNumber == 1){
                mid_card_child.GetComponent<CardValues>().color = "Pik";
                } else if (RandomNumber ==2){
                  mid_card_child.GetComponent<CardValues>().color = "Kier";  
                } else if (RandomNumber == 3){
                    mid_card_child.GetComponent<CardValues>().color = "Karo";
                } else if (RandomNumber == 4){
                 mid_card_child.GetComponent<CardValues>().color = "Trefl";
                }                                         
                }
                mid_card_child.GetComponent<CardValues>().symbol = "As";
                mid_card_child.GetComponent<CardValues>().cardType = "Zmiana";
                mid_card.GetComponent<GetMidCardValue>().midCardColor = mid_card_child.GetComponent<CardValues>().color;                                
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck2.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck2.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck2.GetComponent<Deck2CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Zmieniono kolor na " + mid_card_child.GetComponent<CardValues>().color + ", kolejka gracza 2";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck2.GetComponent<CheckCards2>().enabled = true;            
        } 
    #endregion
    #endregion                
                Debug.Log("Działanie karty zmiany koloru");
                break;
            case "Biala":
                Debug.Log("Działanie karty białej");
                //Show_Joker_Colors.SetActive(true);
                // mid_card_child.GetComponent<CardValues>().enabled = false;
                // if (mid_card_child.GetComponent<CardValues>().enabled == false) {
                // mid_card_child.GetComponent<CardValues>().symbol = "6";
                // mid_card_child.GetComponent<CardValues>().color = "Karo";                
                // mid_card_child.GetComponent<CardValues>().cardType = "Biala";
                //}   
    #region Zamiana kart      
                oldMidCardColor = mid_card.GetComponent<GetMidCardValue>().midCardColor;
                oldMidCardSymbol = mid_card.GetComponent<GetMidCardValue>().midCardSymbol;
                oldMidCardType =  mid_card.GetComponent<GetMidCardValue>().midCardType;            
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = false;                                                
                if (mid_card_child.GetComponent<CardValues>().enabled == false) {
                mid_card_child.GetComponent<CardValues>().symbol = oldMidCardSymbol;
                mid_card_child.GetComponent<CardValues>().color = oldMidCardColor;                
                mid_card_child.GetComponent<CardValues>().cardType = oldMidCardType;                
                }
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck2.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck2.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck2.GetComponent<Deck3CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Zduplikowano kartę";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck2.GetComponent<CheckCards2>().enabled = true;                                         
        }
        Debug.Log("Działanie karty białej");   
        //Debug.Log(stopQueue);
    #endregion
    #endregion                            
                break;

            case "Postojowa":
                stopQueue = true;
    #region Zamiana kart            
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = true;
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck3.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck3.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck3.GetComponent<Deck3CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Kolejka gracza 3, gracz 2 zostaje pominięty";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck3.GetComponent<CheckCards3>().enabled = true;                                         
        }
        Debug.Log("Działanie karty postojowej");
        break;    
        //Debug.Log(stopQueue);
    #endregion
    #endregion
            case "Zwykła":
    #region Zamiana kart            
                old_mid_card = mid_card.transform.GetChild(0);
                old_mid_card.SetParent(CardStash, false);
                old_mid_card.transform.localPosition = new Vector3(-2, -1, -2);
                ClickedSlot.transform.GetChild(0).SetParent(mid_card_parent, false);
                mid_card_child = mid_card.transform.GetChild(0);
                mid_card_child.GetComponent<CardValues>().enabled = true;
                mid_card_child.transform.localScale = new Vector3(1f, 1f, 1f);
                mid_card_child.transform.GetChild(0).localScale = new Vector3(0.03f, 0.03f, 0.03f);
                mid_card_child.transform.GetChild(0).localRotation = new Quaternion(0, 0, 0, 0);
                mid_card_child.transform.localRotation = new Quaternion(0, 0, 0, 0);
                ClickedSlot.GetComponent<GetDeckCardValue>().enabled = false;  
        #region Nastepny gracz
            for (int j = 0; j < 7; j++)
            {
                Deck2.transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
            }
        if (Deck2.transform.GetChild(6).GetComponent<BoxCollider>().enabled == true)
        {
            Deck2.GetComponent<Deck2CardsTransform>().enabled = true;
            for (int i = 0; i < 7; i++)
            {
                Deck1.transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                HelpState.text = "Kolejka gracza 2";
            }
            Deck1.GetComponent<DeckCardsTransform>().enabled = false;
            Deck2.GetComponent<CheckCards2>().enabled = true;
        } 
    #endregion
    #endregion                                    
                Debug.Log("Działanie karty zwykłej");
                break;

        }
        //Debug.Log(stopQueue);

    }


    // Update is called once per frame
void Update()
    {
        if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Ended)
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                //Debug.Log("raycast hit collider gameobject: " + raycastHit.collider.gameObject);
                var TouchedObject = raycastHit.collider.gameObject;
                //Debug.Log("Touched object: " + TouchedObject);
                for (int i=0; i<7;i++){
                    Deck1.transform.GetChild(i).GetComponent<GetDeckCardValue>().enabled = true;
                }
                CardSlot = TouchedObject.transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                CardSymbol = TouchedObject.transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                CardColor = TouchedObject.transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                CardType = TouchedObject.transform.GetComponentInChildren<GetDeckCardValue>().deckCardType.ToString();
                Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

                //porównywanie kart
                if (CheckCards(CardSymbol, CardColor) == "1")
                {
                for (int i=0; i<7;i++){
                    Deck1.transform.GetChild(i).GetComponent<GetDeckCardValue>().enabled = true;
                }
                    //karta ze slotu wybranego wchodzi jako child mid_card - staje się kartą środkową, poprzednia karta ląduje w CardStash;

                Debug.Log(ChosenColor);
                FunctionCards(CardSymbol, CardColor, CardType, TouchedObject);
                
            int licznikZwyciestwa = 0;                
                for (int i = 0; i < 57; i++)
        {

            if (i < 7)
            {
                Transform deckslot = Deck1.transform.GetChild(i);
                if(deckslot.transform.childCount == 0)
                {
                    licznikZwyciestwa++;
                }

            }
            else
            {
                Transform panelSlot = Panel1.transform.GetChild(i - 7);
                if (panelSlot.transform.childCount == 0)
                {
                    licznikZwyciestwa++;
                }
            }
            if(licznikZwyciestwa == 56)
            {
                WinGame.SetActive(true);
            }
        }
                }
                //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                else
                {
                    HelpState.text = "Nie można wybrać tej karty - nie zgadza się z kartą na środku. Wybierz inną lub dobierz kartę";
                    Debug.Log("Nie można wybrać karty, nie pasuje");
                    Vibration.Vibrate(150);

                }

            }
        }
    }
}

