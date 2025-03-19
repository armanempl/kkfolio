using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
         if(Input.touchCount == 1){
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHitdisableCollider;
            Debug.Log("Dotknięto slot_11");
            if (Physics.Raycast(raycast, out raycastHitdisableCollider)){
            raycastHitdisableCollider.collider.enabled = false;
            
           
            }
        }
    }
    
   
}
