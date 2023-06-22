using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    [SerializeField] GameObject meteor;
    [SerializeField] float force;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneratingCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateMeteor()
    {
        int r = Random.Range(0, 2) == 0 ? -11 : 11;
        Rigidbody rb = Instantiate(meteor, new Vector3(0, r, 0), Quaternion.identity).GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.left * Random.Range(-1f, 1f) * force * 4);
        //rb.AddForce(Vector3.down * r * force * Random.Range(0.5f, 1f));
        rb.velocity = new Vector3(Random.Range(-2f, 2f), Random.Range(1f, 4f) * r * -1 / 11, 0);
    }

    IEnumerator GeneratingCoroutine()
    {
        float t = 4f;
        while (true)
        {
            GenerateMeteor();
            yield return new WaitForSeconds(t);
            if (t > 1.5f) t -= 0.1f;
        }
    }
}
