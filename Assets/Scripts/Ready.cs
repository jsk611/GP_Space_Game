using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    public GameObject btn, rb1, rb2;
    Toggle t1, t2;
    public Text txt1, txt2;
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
        if(t1.isOn == true) txt1.color = new Color(73f/255f, 127f/255f, 93f/255f);
        else txt1.color = new Color(143f/255f, 1f, 186f/255f);
        if(t2.isOn == true) txt2.color = new Color(73f/255f, 127f/255f, 93f/255f);
        else txt2.color = new Color(143f/255f, 1f, 186f/255f);
    }
}
