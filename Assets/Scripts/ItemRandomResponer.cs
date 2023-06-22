using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRandomResponer : MonoBehaviour
{
    public GameObject[] items;
    void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    Vector3 Return_RandomPosition() 
    {
        float rangeX = Random.Range(-10f, 10f);
        float rangeY = Random.Range(-7.5f, 7.5f);
        Vector3 RandomPosition = new Vector3(rangeX, rangeY, 0);
        return RandomPosition;
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        float t = 10f;
        while (true)
        {
            yield return new WaitForSeconds(t);
            GameObject item = Instantiate(items[Random.Range(0,3)], Return_RandomPosition(), Quaternion.identity);
            t = t < 5f ? 5 : t - 0.5f;
        }
    }
}
