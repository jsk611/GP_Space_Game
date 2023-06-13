using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle1 : MonoBehaviour
{
    public bool ready1 = false;
    public void ToggleClick1(bool isOn) {
        ready1 = isOn;
        if(ready1 == true) Debug.Log("ready1 true");
        else Debug.Log("ready1 false");
    }
}
