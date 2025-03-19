using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Joker : MonoBehaviour
{

    public GameObject Show_Colors;
    public GameObject Trefl;
    public GameObject Karo;
    public GameObject Kier;
    public GameObject Pik;
    public GameObject Show_color_text;
    public TextMeshPro Change_color_text;
    public GameObject Demand_Card;
    public GameObject Piątka;
    public GameObject Szóstka;
    public GameObject Siodemka;
    public GameObject Ósemka;
    public GameObject Dziewiątka;
    public GameObject Dziesiątka;
    public GameObject Show_Demanded_Card;
    public GameObject Show_Demanded_Card_text;
    public bool AiClick = false; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Ended){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHitJoker;
            if (Physics.Raycast(raycast, out raycastHitJoker)){
                string targetJoker = raycastHitJoker.collider.name;
                if(targetJoker == "card45"){
                    Debug.Log("Dotknięto Jokera");
                    Show_Colors.SetActive(true);
                }
            }
        }
        if(Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Ended){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHitColor;
            if(Physics.Raycast(raycast, out raycastHitColor)){
                
                switch(raycastHitColor.collider.name){
                    case "Club001":
                    Debug.Log("Dotknięto Trefle");
                    Change_color_text.text = "Trefl";
                    Show_color_text.SetActive(false);
                    Show_Colors.SetActive(false);
                    Invoke("showChars", 1f);
                    if(Input.touchCount == 1){
                        Ray raycastDemand = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit raycastHitDemandCard;
                        if(Physics.Raycast(raycastDemand, out raycastHitDemandCard)){
                            switch(raycastHitDemandCard.collider.name){
                                case "Club05":
                                    Debug.Log("Dotknięto piątki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                                case "Club06":
                                    Debug.Log("Dotknięto szóstki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                                
                                case "Club07":
                                    Debug.Log("Dotknięto siódemki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                                case "Club08":
                                    Debug.Log("Dotknięto ósemki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                                case "Club09":
                                    Debug.Log("Dotknięto dziewiątki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                                case "Club10":
                                    Debug.Log("Dotknięto dziesiątki");
                                    Piątka.SetActive(true);
                                    Show_Demanded_Card.SetActive(false);
                                    Show_Demanded_Card_text.SetActive(false);
                                break;
                            }
                        }
                    }
                    break;
                
                case "Diamond001":
                    Debug.Log("Dotknięto Karo");
                    Change_color_text.text = "Karo";
                    Show_color_text.SetActive(false);
                    Show_Colors.SetActive(false);
                    
                    Invoke("showChars", 0.1f);
                break;
                case "Heart001":
                    Debug.Log("Dotknięto Kier");
                    Change_color_text.text = "Kier";
                    Show_color_text.SetActive(false);
                    Show_Colors.SetActive(false);
                    
                    Invoke("showChars", 0.1f);
                break;
                case "Spade001":
                    Debug.Log("Dotknięto Pik");
                    Change_color_text.text = "Pik";
                    Show_color_text.SetActive(false);
                    Show_Colors.SetActive(false);
                    
                    Invoke("showChars", 0.1f);
                break;
                }
            }
        }
        
    }
    void showChars() {
        Demand_Card.SetActive(true);
    }
}
