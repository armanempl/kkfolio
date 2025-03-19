using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Walet : MonoBehaviour
{

    public GameObject DemandCard;
    public GameObject Piątka;
    public GameObject Szóstka;
    public GameObject Siodemka;
    public GameObject Ósemka;
    public GameObject Dziewiątka;
    public GameObject Dziesiątka;

    public GameObject Show_Demanded_Card;
    public GameObject Show_Demanded_Card_text;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if(Input.touchCount == 1){
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit4;
                if (Physics.Raycast(raycast, out raycastHit4)){
                    string targetW = raycastHit4.collider.name;
                    
                    
                    if(targetW == "card54"){
                        Debug.Log("Dotknięto Waleta");
                        DemandCard.SetActive(true);
                    }
                }
            }

            if(Input.touchCount == 1){
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit5;
                if(Physics.Raycast(raycast, out raycastHit5)){
                    switch(raycastHit5.collider.name){
                        case "Club05":
                            Debug.Log("Dotknięto Piątki");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano piątkę";
                            Invoke("Hide_text", 2);
                        break;

                        case "Club06":
                            Debug.Log("Dotknięto Szóstki");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano szóstkę";
                            Invoke("Hide_text", 2);
                        break;

                        case "Club07":
                            Debug.Log("Dotknięto Siodemki");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano siódemkę";
                            Invoke("Hide_text", 2);
                        break;

                        case "Club08":
                            Debug.Log("Dotknięto Ósemki");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano ósemkę";
                            Invoke("Hide_text", 2);
                        break;

                        case "Club09":
                            Debug.Log("Dotknięto Dziewiątkę");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano dziewiątkę";
                            Invoke("Hide_text", 2);
                        break;

                        case "Club10":
                            Debug.Log("Dotknięto Dziesiątkę");
                            DemandCard.SetActive(false);
                            Show_Demanded_Card_text.SetActive(true);
                            Show_Demanded_Card_text.GetComponent<TextMeshPro>().text = "Wybrano dziesiątkę";
                            Invoke("Hide_text", 2);
                        break;

                    }
                }
            }
        
        
    }

    void Hide_text(){
        Show_Demanded_Card_text.SetActive(false);
    }
}
