using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class As : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Show_Colors;
    public GameObject Trefl;
    public GameObject Karo;
    public GameObject Kier;
    public GameObject Pik;

    public GameObject Show_color_text;
    public TextMeshPro Change_color_text;
    
    public string ChosenColor;
 
   
    
    void Start()
    {
      
    }

    // Update is called once per frame
    public void ChooseAce()
    {
       
        if(Input.touchCount == 1 ){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit2;
            if (Physics.Raycast(raycast, out raycastHit2)){
               
                string target = raycastHit2.collider.name;
                // Debug.Log(target);
                // bool mybool = target == "true";
                if(target == "card40"){
                    Debug.Log("Dotknięto Asa");
                    Show_Colors.SetActive(true);
                }
                //  if(raycastHit2.collider.name == "Slot_4")
                //  {
                //     Debug.Log("Dotknięto Asa");
                //     Show_Colors.SetActive(true);
                //  }
            }
        }
            
            

        


    //return ChosenColor;
    }
    void Hide_text(){
        Show_color_text.SetActive(false);
    }
}
