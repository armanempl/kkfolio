using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GetMidCardValue : MonoBehaviour
{
    public string midCardSymbol;
    public string midCardColor;

    public string midCardType;

    public Text midcardText;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
    if (gameObject.name == "mid_card"){
    var ChildCard = transform.GetChild(0);
    if (ChildCard.childCount == 1) {
    midCardSymbol = ChildCard.transform.parent.GetComponentInChildren<CardValues>().symbol.ToString();
    midCardColor = ChildCard.transform.parent.GetComponentInChildren<CardValues>().color.ToString();
    midCardType = ChildCard.transform.GetComponentInChildren<CardValues>().cardType.ToString();
    midcardText.text = midCardSymbol + " "  + midCardColor;
    }//Debug.Log("Środkowa karta to: " + midCardSymbol + " " + midCardColor);
    }
}
}
       