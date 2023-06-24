using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    public GameObject btn, rb1, rb2;
    Toggle t1, t2;
    void Start()
    {
        Screen.SetResolution(1920 / 2, 1080 / 2, false);
        t1 = rb1.GetComponent<Toggle>();
        t2 = rb2.GetComponent<Toggle>();
    }
    void Update()
    {
        if(t1.isOn == true && t2.isOn == true) btn.SetActive(true);
        else btn.SetActive(false);
    }
}
