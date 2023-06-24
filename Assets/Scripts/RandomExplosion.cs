using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExplosion : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    void Start()
    {
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        while (true)
        {
            GameObject e = Instantiate(explosion, new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(2f, -5f), -5f), Quaternion.identity);
            e.GetComponentsInChildren<Transform>()[1].localScale = Vector3.one * Random.Range(0.5f, 1.25f);
            Destroy(e, 1.5f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
