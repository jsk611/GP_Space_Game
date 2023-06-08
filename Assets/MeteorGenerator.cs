using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    [SerializeField] GameObject meteor;
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
        rb.AddForce(Vector3.left * Random.Range(-1f, 1f) * 150);
        rb.AddForce(Vector3.down * r * 20f * Random.Range(0.5f, 1f));
    }

    IEnumerator GeneratingCoroutine()
    {
        while (true)
        {
            GenerateMeteor();
            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }
}
