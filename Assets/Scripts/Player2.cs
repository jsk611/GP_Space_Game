using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float force;
    public float maxSpeed;
    public Rigidbody rb;

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
        //h = 0; v = 0;

        //#region MovingKeySetting
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    h = 1;
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    h = -1;
        //}
        //if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        //{
        //    h = 0;
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    v = 1;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    v = -1;
        //}
        //if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        //{
        //    v = 0;
        //}
        //#endregion

        //rb.AddForce(new Vector3(h, v, 0) * force);

        if (rb.velocity.x > 0) transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        if (rb.velocity.x < 0) transform.localScale = new Vector3(0.5f, -0.5f, 1f);
    }

    private void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;

        if (velocity.magnitude > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed;
        }

        rb.velocity = velocity;
    }

}
