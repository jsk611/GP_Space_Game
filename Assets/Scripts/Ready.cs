using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    public GameObject btn;
    public bool ready1 = false;
    public bool ready2 = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(ready1 == true && ready2 == true) btn.SetActive(true);
        else btn.SetActive(false);
    }

    public void Ready1Click() {
        ready1 = !ready1;
    }
    public void Ready2Click() {
        ready2 = !ready2;
    }
}
