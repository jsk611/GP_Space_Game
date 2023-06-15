using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            h = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            h = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            h = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            v = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            v = 0;
        }
        #endregion

        rb.AddForce(new Vector3(h, v, 0) * force);
    }
}
