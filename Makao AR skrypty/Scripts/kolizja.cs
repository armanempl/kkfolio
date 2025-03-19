using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("kolizja" + other.gameObject.name);
    }
}
