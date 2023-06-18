using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float force;
    public float maxSpeed;
    public Rigidbody rb;

    [SerializeField] Player1Move p1m;
    [SerializeField] Player2Move p2m;
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
        //if (Input.GetKey(KeyCode.D))
        //{
        //    h = 1;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    h = -1;
        //}
        //if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        //{
        //    h = 0;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    v = 1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    v = -1;
        //}
        //if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
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

    IEnumerator CoilEffect()
    {
        rb.mass = 100f;
        if (p1m != null) p1m.force = 8000f;
        if (p2m != null) p2m.force = 8000f;
        yield return new WaitForSeconds(10f);
        rb.mass = 50f;
        if (p1m != null) p1m.force = 4000f;
        if (p2m != null) p2m.force = 4000f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coil"))
        {
            StartCoroutine(CoilEffect());
            Destroy(other.gameObject);
        }
    }
}
