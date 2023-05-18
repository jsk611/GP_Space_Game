using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
