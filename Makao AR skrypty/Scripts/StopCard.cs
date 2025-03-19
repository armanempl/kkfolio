using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StopCard : MonoBehaviour
{

    public GameObject Card ;
    public GameObject Show_stop_text;
    public TextMeshPro Change_stop_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHitStop;
            if (Physics.Raycast(raycast, out raycastHitStop)){
                if(raycastHitStop.collider.name == "Slot_6"){
                    Debug.Log("Dotknięto Czwórki");
                    Show_stop_text.SetActive(true);
                    Change_stop_text.text = "Wybrano czwórkę";
                    Invoke("Hide_text", 2);
                }
            }
        }
    }
    
    void Hide_text() {
        Show_stop_text.SetActive(false);
    }
}
