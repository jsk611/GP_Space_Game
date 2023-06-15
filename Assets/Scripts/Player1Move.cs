using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    float h = 0;
    float v = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = 0; v = 0;

        #region MovingKeySetting
        if (Input.GetKey(KeyCode.D))
        {
            h = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            h = -1;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            h = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            v = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            v = -1;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            v = 0;
        }
        #endregion

        rb.AddForce(new Vector3(h, v, 0) * force);
    }
}
