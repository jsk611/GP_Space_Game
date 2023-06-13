using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    float randomScale;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        randomScale = Random.Range(0.5f, 2f);
        transform.localScale *= randomScale;
        rb.mass = 80 * randomScale * randomScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Planet"))
        {
            collision.gameObject.GetComponent<Planet>().Hp -= randomScale * 10;
            Destroy(gameObject);
        }
    }
}
