using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCards2 : MonoBehaviour
{

    public GameObject get_Slot;
    public string deck_Card_Symbol;
    public string deck_Card_Color;
    public string deck_Card_Type;

     public string mid_Card_Symbol;
    public string mid_Card_Color;

    public string mid_Card_Type;
    // public string get_Collider_Name;
    public GameObject mid_card;
    Collider get_Collider_Name;
    public DeckCardsTransform Deck1;
    public Deck2CardsTransform Deck2;
    public Deck3CardsTransform Deck3;
    public Deck4CardsTransform Deck4;    
    
    bool isDone = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void OnEnable()
    {
        
        while(!isDone)
        {
        string diffmidCardSymbol = mid_card.transform.GetComponent<GetMidCardValue>().midCardSymbol.ToString();
        string diffmidCardColor = mid_card.transform.GetComponent<GetMidCardValue>().midCardColor.ToString();
        Debug.Log("Karta na środku: " + diffmidCardSymbol + " " + diffmidCardColor);
        for(int i = 0; i < 7; i++ ){
            get_Collider_Name = transform.GetChild(i).GetComponent<Collider>();
            Debug.Log("collider name: " + get_Collider_Name);
            get_Slot = transform.GetChild(i).gameObject;
            if (get_Slot == null){
                Debug.Log(get_Slot + " pusty");
                i++;
            }else{
            Debug.Log(get_Slot);
            deck_Card_Type = transform.GetChild(i).GetChild(0).GetComponentInChildren<CardValues>().cardType.ToString();
            deck_Card_Color = transform.GetChild(i).GetChild(0).GetComponentInChildren<CardValues>().color.ToString();
            deck_Card_Symbol = transform.GetChild(i).GetChild(0).GetComponentInChildren<CardValues>().symbol.ToString();
            // string z = GameObject.Find("As_Trefl").GetComponent<As>().AiClick;
            // Debug.Log(z);
            // z = "true";
            // Debug.Log(z);
            if( diffmidCardColor == deck_Card_Color || diffmidCardSymbol == deck_Card_Symbol || deck_Card_Color == "1" || deck_Card_Color == "2"){
              Deck2.FunctionCards(deck_Card_Symbol, deck_Card_Color, deck_Card_Type, get_Slot);
               break;
                // Debug.Log("Wyrzuć kartę" + (i+1));
                // get_Collider_Name.isTrigger = true;
               
               // Debug.Log("dsadasdasd: " );

            }
            else {
                Debug.Log("Nie wyrzuć karty" + (i+1));
            }
            
            // Debug.Log("Type: " + deck_Card_Type);
            // Debug.Log("Color: " + deck_Card_Color);
            // Debug.Log("Symbol: " + deck_Card_Symbol);
        }

        isDone = true;
        }
        }
       
         
    }
}
