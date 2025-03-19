using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDeckCardValue : MonoBehaviour
{

    public string deckCardSymbol;
    public string deckCardColor;
    public string deckCardType;
    public string slotName;
    // Start is called before the first frame update
    void Start()
    {

       // Debug.Log("Karta w " + slotName + " to: " + deckCardSymbol + " " + deckCardColor);  
    }

    // Update is called once per frame
     void Update()
     {
         if (transform.childCount == 0){
     deckCardSymbol = transform.GetComponentInChildren<CardValues>().symbol = null;
     deckCardColor = transform.GetComponentInChildren<CardValues>().color = null;
     deckCardType = transform.GetComponentInChildren<CardValues>().cardType = null;
     } else{    
     slotName = transform.name;
     deckCardSymbol = transform.GetComponentInChildren<CardValues>().symbol.ToString();
     deckCardColor = transform.GetComponentInChildren<CardValues>().color.ToString();
     deckCardType = transform.GetComponentInChildren<CardValues>().cardType.ToString();
     }

     }
}
