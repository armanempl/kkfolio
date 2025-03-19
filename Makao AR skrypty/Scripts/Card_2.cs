using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card_2 : MonoBehaviour
{
    public GameObject Show_text;
    public TextMeshPro Change_Text_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit HitCard2;
            if(Physics.Raycast(raycast, out HitCard2)){
                string targetCard2 = HitCard2.collider.name;
                if( targetCard2 == "card4"){
                    Debug.Log("Dotknięto karty 2");
                    Show_text.SetActive(true);
                    Change_Text_2.text = "Wybrano 2";
                    Invoke("Hide_text", 2);

                }
            }
        }
    }

    void Hide_text(){ 
        Show_text.SetActive(false);
    }
}
