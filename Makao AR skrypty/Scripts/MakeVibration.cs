using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVibration : MonoBehaviour
{
public void onClickVibrateButton()
    {
        Vibration.Vibrate(400);
    }
}
