using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckCardSelectPlace : MonoBehaviour
{
    Animator _animator;
    public string CardSymbol;
    public string CardColor;
    public string CardType;
    public string CardSlot;
    public GameObject mid_card;


     string CheckCards(string CardSymbol, string CardColor){
        string isCardSame;
        string diffmidCardSymbol = mid_card.transform.GetComponent<GetMidCardValue>().midCardSymbol.ToString();
        string diffmidCardColor = mid_card.transform.GetComponent<GetMidCardValue>().midCardColor.ToString();
        Debug.Log("Karta na środku: " + diffmidCardSymbol + " " + diffmidCardColor);
        if (CardSymbol == diffmidCardSymbol || diffmidCardColor == CardColor || CardColor == "1" || CardColor == "2"){
            isCardSame = "1";
            Debug.Log("Karty zgadzają się, można zagrać " + isCardSame);        
        return isCardSame;
        } else {
            isCardSame = "0";
            Debug.Log("Karty nie zgadzają się, należy wziąć inną kartę " + isCardSame); 
        return isCardSame;           
        }
     }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Ended){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit)){
                //Debug.Log("Dotknięto");
                //Debug.Log ("Dotknięto karty " + raycastHit.collider.name);
                switch (raycastHit.collider.name){
            //jeżeli dotknięta karta to ta ze slotu 1, pobranie ze środkowej i wybranej karty wartości        
                    case "Slot_1":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_1") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce1", true);
                    _animator.SetBool("isTouchedTwice1", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedTwice1", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_1_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_1_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce1_2", true);
                    _animator.SetBool("isTouchedTwice1_2", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedTwice1_2", false);
                    }
                    } else {    
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_1_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_1_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce1_3", true);
                    _animator.SetBool("isTouchedTwice1_3", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce1_3", false);
                    _animator.SetBool("isTouchedTwice1_3", false);
                    }
                    } else {
                    _animator.SetBool("isTouchedOnce1", false);                                
                    _animator.SetBool("isTouchedOnce1_2", false);                                   
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_1_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_1_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce1_4", true);
                    _animator.SetBool("isTouchedTwice1_4", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedTwice1_4", false);
                    }
                    } else {  
                    _animator.SetBool("isTouchedOnce1", false);                              
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce2", true);
                    _animator.SetBool("isTouchedTwice2", false);                    
                   }
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedTwice2", false);                                                                    
                    Vibration.Vibrate(150);
                    }
                    } else {                   
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_2_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_2_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce2_2", true);
                    _animator.SetBool("isTouchedTwice2_2", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce2_2", false);
                    _animator.SetBool("isTouchedTwice2_2", false);
                    }
                    } else {  
                    _animator.SetBool("isTouchedOnce1", false);                                                
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);                                         
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_2_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_2_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce2_3", true);
                    _animator.SetBool("isTouchedTwice2_3", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce2_3", false);
                    _animator.SetBool("isTouchedTwice2_3", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_2_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_2_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce2_4", true);
                    _animator.SetBool("isTouchedTwice2_4", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce2_4", false);
                    _animator.SetBool("isTouchedTwice2_4", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce3", true);
                    _animator.SetBool("isTouchedTwice3", false);                                        
                   }
                    else {
                    _animator.SetBool("isTouchedOnce3", false);
                    _animator.SetBool("isTouchedTwice3", false);                         
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                      
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce1", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_3_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_3_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce3_2", true);
                    _animator.SetBool("isTouchedTwice3_2", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce3_2", false);
                    _animator.SetBool("isTouchedTwice3_2", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_3_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_3_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce3_3", true);
                    _animator.SetBool("isTouchedTwice3_3", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce3_3", false);
                    _animator.SetBool("isTouchedTwice3_3", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_3_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_3_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce3_4", true);
                    _animator.SetBool("isTouchedTwice3_4", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce3_4", false);
                    _animator.SetBool("isTouchedTwice3_4", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce4", true);
                    _animator.SetBool("isTouchedTwice4", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedTwice4", false);                         
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;

                    case "Slot_4_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_4_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce4_2", true);
                    _animator.SetBool("isTouchedTwice4_2", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce4_2", false);
                    _animator.SetBool("isTouchedTwice4_2", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_4_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_4_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce4_3", true);
                    _animator.SetBool("isTouchedTwice4_3", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce4_3", false);
                    _animator.SetBool("isTouchedTwice4_3", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_4_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_4_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce4_4", true);
                    _animator.SetBool("isTouchedTwice4_4", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce4_4", false);
                    _animator.SetBool("isTouchedTwice4_4", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_5":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_5") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce5", true);
                    _animator.SetBool("isTouchedTwice5", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedTwice5", false);                         
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;
                    case "Slot_5_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_5_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce5_2", true);
                    _animator.SetBool("isTouchedTwice5_2", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedTwice5_2", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;
                    case "Slot_5_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_5_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce5_3", true);
                    _animator.SetBool("isTouchedTwice5_3", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce5_3", false);
                    _animator.SetBool("isTouchedTwice5_3", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce1", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;
                    case "Slot_5_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_5_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);

            //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce5_4", true);
                    _animator.SetBool("isTouchedTwice5_4", false);
                   }
            //jeżeli nie pasują, wibracja, komunikat i cofnięcie karty (w sensie i tak nie wyciągnie jej na stół)       
                    else {
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedTwice5_4", false);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }
                    break;

                    case "Slot_6":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_6") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce6", true);
                    _animator.SetBool("isTouchedTwice6", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce6", false); 
                    _animator.SetBool("isTouchedTwice6", false);                                            
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;

                    case "Slot_6_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_6_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce6_2", true);
                    _animator.SetBool("isTouchedTwice6_2", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce6_2", false); 
                    _animator.SetBool("isTouchedTwice6_2", false);                                            
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce1", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;

                    case "Slot_6_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_6_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce6_3", true);
                    _animator.SetBool("isTouchedTwice6_3", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedTwice6_3", false);                                            
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;

                    case "Slot_6_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_6_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce6_4", true);
                    _animator.SetBool("isTouchedTwice6_4", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedTwice6_4", false);                                            
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                     
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                  
                    break;

                    case "Slot_7":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_7") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce7", true);
                    _animator.SetBool("isTouchedTwice7", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedTwice7", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_7_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_7_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce7_2", true);
                    _animator.SetBool("isTouchedTwice7_2", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce7_2", false);
                    _animator.SetBool("isTouchedTwice7_2", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_7_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_7_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce7_3", true);
                    _animator.SetBool("isTouchedTwice7_3", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce7_3", false);
                    _animator.SetBool("isTouchedTwice7_3", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_7_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_7_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce7_4", true);
                    _animator.SetBool("isTouchedTwice7_4", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce7_4", false);
                    _animator.SetBool("isTouchedTwice7_4", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_8":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_8") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce8", true);
                    _animator.SetBool("isTouchedTwice8", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedTwice8", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_8_2":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_8_2") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce8_2", true);
                    _animator.SetBool("isTouchedTwice8_2", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce8_2", false);
                    _animator.SetBool("isTouchedTwice8_2", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_8_3":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_8_3") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce8_3", true);
                    _animator.SetBool("isTouchedTwice8_3", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce8_3", false);
                    _animator.SetBool("isTouchedTwice8_3", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;

                    case "Slot_8_4":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_8_4") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce8_4", true);
                    _animator.SetBool("isTouchedTwice8_4", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce8_4", false);
                    _animator.SetBool("isTouchedTwice8_4", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce1", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_9":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_9") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce9", true);
                    _animator.SetBool("isTouchedTwice9", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedTwice9", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_10":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_10") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce10", true);
                    _animator.SetBool("isTouchedTwice10", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedTwice10", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_11":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_11") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce11", true);
                    _animator.SetBool("isTouchedTwice11", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedTwice11", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_12":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_12") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce12", true);
                    _animator.SetBool("isTouchedTwice12", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedTwice12", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_13":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_13") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce13", true);
                    _animator.SetBool("isTouchedTwice13", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedTwice13", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    _animator.SetBool("isTouchedOnce14", false);
                    }                    
                    break;
                    
                    case "Slot_14":
                    CardSlot = transform.GetComponentInChildren<GetDeckCardValue>().slotName.ToString();
                    if (CardSlot == "Slot_14") {
                    CardSymbol = transform.GetComponentInChildren<GetDeckCardValue>().deckCardSymbol.ToString();
                    CardColor = transform.GetComponentInChildren<GetDeckCardValue>().deckCardColor.ToString();
                    Debug.Log("Wybrana karta to: " + CardSymbol + " " + CardColor);
                    //porównywanie kart
                   if (CheckCards(CardSymbol, CardColor) == "1") {
                    _animator.SetBool("isTouchedOnce14", true);
                    _animator.SetBool("isTouchedTwice14", false);                     
                   }
                    else {
                    _animator.SetBool("isTouchedOnce14", false);
                    _animator.SetBool("isTouchedTwice14", false);                  
                    Debug.Log("Nie można wybrać karty, nie pasuje");                        
                    Vibration.Vibrate(150);
                    }
                    } else {                       
                    _animator.SetBool("isTouchedOnce1_2", false);
                    _animator.SetBool("isTouchedOnce1_3", false);                                        
                    _animator.SetBool("isTouchedOnce1_4", false);
                    _animator.SetBool("isTouchedOnce2_2", false);                                           
                    _animator.SetBool("isTouchedOnce2_3", false); 
                    _animator.SetBool("isTouchedOnce2_4", false); 
                    _animator.SetBool("isTouchedOnce3_2", false); 
                    _animator.SetBool("isTouchedOnce3_3", false); 
                    _animator.SetBool("isTouchedOnce3_4", false); 
                    _animator.SetBool("isTouchedOnce4_2", false); 
                    _animator.SetBool("isTouchedOnce4_3", false); 
                    _animator.SetBool("isTouchedOnce4_4", false); 
                    _animator.SetBool("isTouchedOnce5_2", false);
                    _animator.SetBool("isTouchedOnce5_3", false);                                        
                    _animator.SetBool("isTouchedOnce5_4", false);
                    _animator.SetBool("isTouchedOnce6_2", false);                                           
                    _animator.SetBool("isTouchedOnce6_3", false); 
                    _animator.SetBool("isTouchedOnce6_4", false); 
                    _animator.SetBool("isTouchedOnce7_2", false); 
                    _animator.SetBool("isTouchedOnce7_3", false); 
                    _animator.SetBool("isTouchedOnce7_4", false); 
                    _animator.SetBool("isTouchedOnce8_2", false); 
                    _animator.SetBool("isTouchedOnce8_3", false); 
                    _animator.SetBool("isTouchedOnce8_4", false); 
                    _animator.SetBool("isTouchedOnce9_2", false);
                    _animator.SetBool("isTouchedOnce9_3", false);                                        
                    _animator.SetBool("isTouchedOnce9_4", false);
                    _animator.SetBool("isTouchedOnce10_2", false);                                           
                    _animator.SetBool("isTouchedOnce10_3", false); 
                    _animator.SetBool("isTouchedOnce10_4", false); 
                    _animator.SetBool("isTouchedOnce11_2", false); 
                    _animator.SetBool("isTouchedOnce11_3", false); 
                    _animator.SetBool("isTouchedOnce11_4", false); 
                    _animator.SetBool("isTouchedOnce12_2", false); 
                    _animator.SetBool("isTouchedOnce12_3", false); 
                    _animator.SetBool("isTouchedOnce12_4", false); 
                    _animator.SetBool("isTouchedOnce13_2", false);
                    _animator.SetBool("isTouchedOnce13_3", false);                                        
                    _animator.SetBool("isTouchedOnce13_4", false);
                    _animator.SetBool("isTouchedOnce14_2", false);                                           
                    _animator.SetBool("isTouchedOnce14_3", false); 
                    _animator.SetBool("isTouchedOnce14_4", false);                                                                
                    _animator.SetBool("isTouchedOnce2", false);
                    _animator.SetBool("isTouchedOnce3", false);                    
                    _animator.SetBool("isTouchedOnce4", false);
                    _animator.SetBool("isTouchedOnce5", false);
                    _animator.SetBool("isTouchedOnce6", false);
                    _animator.SetBool("isTouchedOnce7", false);
                    _animator.SetBool("isTouchedOnce8", false);
                    _animator.SetBool("isTouchedOnce9", false);
                    _animator.SetBool("isTouchedOnce10", false);
                    _animator.SetBool("isTouchedOnce11", false);
                    _animator.SetBool("isTouchedOnce12", false);
                    _animator.SetBool("isTouchedOnce13", false);
                    _animator.SetBool("isTouchedOnce1", false);
                    }                    
                    break;

                }

            }
        }

//dotknięcie wybranej karty dwoma palcami
     if (Input.touchCount == 2 && Input.touches[0].phase == TouchPhase.Ended){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit)){
                Debug.Log("Dotknięto");
                switch (raycastHit.collider.name){
                    case "Slot_1":
                    _animator.SetBool("isTouchedTwice1", true);
                    //_animator.SetBool("isTouchedOnce", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_1_2":
                    _animator.SetBool("isTouchedTwice1_2", true);
                    //_animator.SetBool("isTouchedOnce", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_1_3":
                    _animator.SetBool("isTouchedTwice1_3", true);
                    //_animator.SetBool("isTouchedOnce", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_1_4":
                    _animator.SetBool("isTouchedTwice1_4", true);
                    //_animator.SetBool("isTouchedOnce", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;                                                            
                    case "Slot_2":
                    _animator.SetBool("isTouchedTwice2", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_2_2":
                    _animator.SetBool("isTouchedTwice2_2", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_2_3":
                    _animator.SetBool("isTouchedTwice2_3", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_2_4":
                    _animator.SetBool("isTouchedTwice2_4", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_3":
                    _animator.SetBool("isTouchedTwice3", true);
                    //_animator.SetBool("isTouchedOnce3", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_3_2":
                    _animator.SetBool("isTouchedTwice3_2", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_3_3":
                    _animator.SetBool("isTouchedTwice3_3", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_3_4":
                    _animator.SetBool("isTouchedTwice3_4", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_4":
                    _animator.SetBool("isTouchedTwice4", true);
                    //_animator.SetBool("isTouchedOnce4", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_4_2":
                    _animator.SetBool("isTouchedTwice4_2", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_4_3":
                    _animator.SetBool("isTouchedTwice4_3", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_4_4":
                    _animator.SetBool("isTouchedTwice4_4", true);
                    //_animator.SetBool("isTouchedOnce2", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;

                    case "Slot_5":
                    _animator.SetBool("isTouchedTwice5", true);
                    //_animator.SetBool("isTouchedOnce5", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_6":
                    _animator.SetBool("isTouchedTwice6", true);
                    //_animator.SetBool("isTouchedOnce5", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                    case "Slot_7":
                    _animator.SetBool("isTouchedTwice7", true);
                    //_animator.SetBool("isTouchedOnce5", false);
                    Debug.Log ("Dotknięto karty " + raycastHit.collider.name + " drugi raz");
                    break;
                }
            }
        }
    
    }

}

