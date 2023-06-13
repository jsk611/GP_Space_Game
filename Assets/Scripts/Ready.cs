using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    public GameObject btn, rbtn1, rbtn2;
    bool ready1;
    bool ready2;
    void Start()
    {
        rbtn1 = GameObject.Find("P1 ready");
        rbtn2 = GameObject.Find("P2 ready");
    }
    void Update()
    {
        ready1 = rbtn1.GetComponent<Toggle>().ready1;
        ready2 = rbtn2.GetComponent<Toggle>().ready2;
        if(ready1 == true && ready2 == true) btn.SetActive(true);
        else btn.SetActive(false);
    }
}
