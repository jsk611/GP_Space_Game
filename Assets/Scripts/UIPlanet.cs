using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlanet : MonoBehaviour
{
    public float rspeed;
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rspeed);
    }
}
