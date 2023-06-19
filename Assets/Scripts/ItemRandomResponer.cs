using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRandomResponer : MonoBehaviour
{
    public GameObject item1;
    void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    Vector3 Return_RandomPosition() 
    {
        float rangeX = Random.Range(-10, 11);
        float rangeY = Random.Range(-10, 11);
        Vector3 RandomPosition = new Vector3(rangeX, rangeY, 0);
        return RandomPosition;
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameObject item = Instantiate(item1, Return_RandomPosition(), Quaternion.identity);
        }
    }
}
