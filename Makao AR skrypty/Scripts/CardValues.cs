using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardValues : MonoBehaviour
{
    public string symbol;
    public string color;
    public string cardType;
    public string prefabCardName;
  

    //GameObject Child;

    // Start is called before the first frame update
    void Start()
    {
    

        //Wyciągnięcie z parentu card* nazwę prefabu childa (np. 2_Karo)
        string prefabName = transform.GetChild(0).ToString();

        switch (prefabName){
            //Nie wiem czemu tak działa, ale trzeba dopisywać UnityEngine.Transform do warunku żeby zadziałał
            
            case "2_Karo (UnityEngine.Transform)":
            symbol = "2";
            color = "Karo";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabCardName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Kier (UnityEngine.Transform)":
            symbol = "2";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Pik (UnityEngine.Transform)":
            symbol = "2";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Trefl (UnityEngine.Transform)":
            symbol = "2";
            color = "Trefl";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Karo (UnityEngine.Transform)":
            symbol = "3";
            color = "Karo";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Kier (UnityEngine.Transform)":
            symbol = "3";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Pik (UnityEngine.Transform)":
            symbol = "3";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Trefl (UnityEngine.Transform)":
            symbol = "3";
            color = "Trefl";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Karo (UnityEngine.Transform)":
            symbol = "4";
            color = "Karo";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Kier (UnityEngine.Transform)":
            symbol = "4";
            color = "Kier";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Pik (UnityEngine.Transform)":
            symbol = "4";
            color = "Pik";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Trefl (UnityEngine.Transform)":
            symbol = "4";
            color = "Trefl";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Karo (UnityEngine.Transform)":
            symbol = "5";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Kier (UnityEngine.Transform)":
            symbol = "5";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Pik (UnityEngine.Transform)":
            symbol = "5";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Trefl (UnityEngine.Transform)":
            symbol = "5";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Karo (UnityEngine.Transform)":
            symbol = "6";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Kier (UnityEngine.Transform)":
            symbol = "6";
            color = "Kier";
            cardType = "Zwykła";
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Pik (UnityEngine.Transform)":
            symbol = "6";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Trefl (UnityEngine.Transform)":
            symbol = "6";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Karo (UnityEngine.Transform)":
            symbol = "7";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Kier (UnityEngine.Transform)":
            symbol = "7";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Pik (UnityEngine.Transform)":
            symbol = "7";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Trefl (UnityEngine.Transform)":
            symbol = "7";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Karo (UnityEngine.Transform)":
            symbol = "8";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Kier (UnityEngine.Transform)":
            symbol = "8";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Pik (UnityEngine.Transform)":
            symbol = "8";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Trefl (UnityEngine.Transform)":
            symbol = "8";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Karo (UnityEngine.Transform)":
            symbol = "9";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Kier (UnityEngine.Transform)":
            symbol = "9";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Pik (UnityEngine.Transform)":
            symbol = "9";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Trefl (UnityEngine.Transform)":
            symbol = "9";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Karo (UnityEngine.Transform)":
            symbol = "10";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Kier (UnityEngine.Transform)":
            symbol = "10";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Pik (UnityEngine.Transform)":
            symbol = "10";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Trefl (UnityEngine.Transform)":
            symbol = "10";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Karo (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Karo";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Kier (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Kier";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Pik (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Pik";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Trefl (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Trefl";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Karo (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Kier (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Pik (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Trefl (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;

            case "Krol_Karo (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Karo";
            cardType = "Zwykla";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;  

            case "Krol_Kier (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Krol_Pik (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Krol_Trefl (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Trefl";
            cardType = "Zwykla";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Joker_1 (UnityEngine.Transform)":
            symbol = "Joker";
            color = "1";
            cardType = "Biala";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Joker_2 (UnityEngine.Transform)":
            symbol = "Joker";
            color = "2";
            cardType = "Biala";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Karo (UnityEngine.Transform)":
            symbol = "As";
            color = "Karo";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Kier (UnityEngine.Transform)":
            symbol = "As";
            color = "Kier";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Pik (UnityEngine.Transform)":
            symbol = "As";
            color = "Pik";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Trefl (UnityEngine.Transform)":
            symbol = "As";
            color = "Trefl";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;

            default: //Debug.Log("Coś się popsuło");
            break;
        }

    }
void OnEnable(){
    //Wyciągnięcie z parentu card* nazwę prefabu childa (np. 2_Karo)
        string prefabName = transform.GetChild(0).ToString();

        switch (prefabName){
            //Nie wiem czemu tak działa, ale trzeba dopisywać UnityEngine.Transform do warunku żeby zadziałał
            
            case "2_Karo (UnityEngine.Transform)":
            symbol = "2";
            color = "Karo";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabCardName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Kier (UnityEngine.Transform)":
            symbol = "2";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Pik (UnityEngine.Transform)":
            symbol = "2";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "2_Trefl (UnityEngine.Transform)":
            symbol = "2";
            color = "Trefl";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Karo (UnityEngine.Transform)":
            symbol = "3";
            color = "Karo";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Kier (UnityEngine.Transform)":
            symbol = "3";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Pik (UnityEngine.Transform)":
            symbol = "3";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "3_Trefl (UnityEngine.Transform)":
            symbol = "3";
            color = "Trefl";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Karo (UnityEngine.Transform)":
            symbol = "4";
            color = "Karo";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Kier (UnityEngine.Transform)":
            symbol = "4";
            color = "Kier";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Pik (UnityEngine.Transform)":
            symbol = "4";
            color = "Pik";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "4_Trefl (UnityEngine.Transform)":
            symbol = "4";
            color = "Trefl";
            cardType = "Postojowa";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Karo (UnityEngine.Transform)":
            symbol = "5";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Kier (UnityEngine.Transform)":
            symbol = "5";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Pik (UnityEngine.Transform)":
            symbol = "5";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "5_Trefl (UnityEngine.Transform)":
            symbol = "5";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Karo (UnityEngine.Transform)":
            symbol = "6";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Kier (UnityEngine.Transform)":
            symbol = "6";
            color = "Kier";
            cardType = "Zwykła";
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Pik (UnityEngine.Transform)":
            symbol = "6";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "6_Trefl (UnityEngine.Transform)":
            symbol = "6";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Karo (UnityEngine.Transform)":
            symbol = "7";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Kier (UnityEngine.Transform)":
            symbol = "7";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Pik (UnityEngine.Transform)":
            symbol = "7";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "7_Trefl (UnityEngine.Transform)":
            symbol = "7";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Karo (UnityEngine.Transform)":
            symbol = "8";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Kier (UnityEngine.Transform)":
            symbol = "8";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Pik (UnityEngine.Transform)":
            symbol = "8";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "8_Trefl (UnityEngine.Transform)":
            symbol = "8";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Karo (UnityEngine.Transform)":
            symbol = "9";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Kier (UnityEngine.Transform)":
            symbol = "9";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Pik (UnityEngine.Transform)":
            symbol = "9";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "9_Trefl (UnityEngine.Transform)":
            symbol = "9";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Karo (UnityEngine.Transform)":
            symbol = "10";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Kier (UnityEngine.Transform)":
            symbol = "10";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Pik (UnityEngine.Transform)":
            symbol = "10";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "10_Trefl (UnityEngine.Transform)":
            symbol = "10";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Karo (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Karo";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Kier (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Kier";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Pik (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Pik";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Walet_Trefl (UnityEngine.Transform)":
            symbol = "Walet";
            color = "Trefl";
            cardType = "Zadanie";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Karo (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Karo";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Kier (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Kier";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Pik (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Pik";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Dama_Trefl (UnityEngine.Transform)":
            symbol = "Dama";
            color = "Trefl";
            cardType = "Zwykła";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;

            case "Krol_Karo (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Karo";
            cardType = "Zwykla";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;  

            case "Krol_Kier (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Kier";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Krol_Pik (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Pik";
            cardType = "Wojenna";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Krol_Trefl (UnityEngine.Transform)":
            symbol = "Krol";
            color = "Trefl";
            cardType = "Zwykla";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Joker_1 (UnityEngine.Transform)":
            symbol = "Joker";
            color = "1";
            cardType = "Biala";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "Joker_2 (UnityEngine.Transform)":
            symbol = "Joker";
            color = "2";
            cardType = "Biala";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Karo (UnityEngine.Transform)":
            symbol = "As";
            color = "Karo";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Kier (UnityEngine.Transform)":
            symbol = "As";
            color = "Kier";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Pik (UnityEngine.Transform)":
            symbol = "As";
            color = "Pik";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;
            
            case "As_Trefl (UnityEngine.Transform)":
            symbol = "As";
            color = "Trefl";
            cardType = "Zmiana";
            prefabCardName = prefabName;
            //Debug.Log("Nazwa prefabu: " + prefabName + " , symbol: " + symbol + " , kolor: " + color + " , typ karty: " + cardType);
            break;

            default: //Debug.Log("Coś się popsuło");
            break;
}

}
}
