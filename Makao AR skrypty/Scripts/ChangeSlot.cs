using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSlot : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Panel1;
    public GameObject on;
    public GameObject off;
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Ended)
        {
            Ray raycastSlot = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHitSlot;
            if (Physics.Raycast(raycastSlot, out raycastHitSlot))
            {
                var slot = raycastHitSlot.collider.gameObject;
                Debug.Log(slot.transform.GetChild(0).name);



                if (Slot1.transform.childCount == 0)
                {
                    
                    slot.transform.GetChild(0).SetParent(Slot1.transform);
                    Slot1.transform.GetChild(0).localScale = new Vector3(28, 28, 1);
                    //  Slot1.transform.GetChild(0).SetParent(slot.transform);
                }
                else
                {
                    
                    slot.transform.GetChild(0).SetParent(Slot1.transform);
                    Slot1.transform.GetChild(0).SetParent(slot.transform);
                    
                    slot.transform.GetChild(0).localScale = new Vector3(33, 33, 1);
                    Slot1.transform.GetChild(0).localScale = new Vector3(28, 28, 1);
                }

                Debug.Log("Nazwa slota:" + Slot1.transform.GetChild(0).name);

                Slot1.transform.GetChild(0).transform.localPosition = new Vector3(0, 0, 0);
                slot.transform.GetChild(0).transform.localPosition = new Vector3(0, 0, 0);

                Panel1.gameObject.SetActive(false);
                on.gameObject.SetActive(true);
                off.gameObject.SetActive(false);
            }
        }
    }
}