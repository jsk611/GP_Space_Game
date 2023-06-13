using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle2 : MonoBehaviour
{
    public bool ready2;
    public void ToggleClick2(bool isOn) {
        ready2 = isOn;
        if(ready2 == true) Debug.Log("ready2 true");
        else Debug.Log("ready2 false");
    }
}
