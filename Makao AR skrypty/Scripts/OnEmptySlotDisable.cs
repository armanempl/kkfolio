using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEmptySlotDisable : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0){
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<GetDeckCardValue>().enabled = false;
        // } else if (transform.childCount == 1){
        //     gameObject.GetComponent<BoxCollider>().enabled = true;
        //     gameObject.GetComponent<GetDeckCardValue>().enabled = true;
        }
    }
}
