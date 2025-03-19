using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerDo : MonoBehaviour
{
    // Start is called before the first frame update
    Animator m_Animator;
    private void Start()
    {
       Accelerometer.Instance.onShake += ActionToRunWhenShakingDevice;
       m_Animator = gameObject.GetComponent<Animator>();
       m_Animator.SetBool("isShaking", false);
        
    }

    // Update is called once per frame
    

    private void ActionToRunWhenShakingDevice()
    {
        // UnityEngine.Debug.Log("Shake");
        // UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
        m_Animator.SetBool("isShaking", true);

    }
}
