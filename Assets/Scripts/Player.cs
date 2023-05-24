using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float force;
    public float maxSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(h, v, 0) * force);

    }

    private void FixedUpdate()
    {
        // 현재 속도 벡터를 가져옵니다.
        Vector3 velocity = rb.velocity;

        // 속도 벡터의 길이가 최대 속도보다 큰 경우, 길이를 최대 속도로 제한합니다.
        if (velocity.magnitude > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed;
        }

        // 제한된 속도 벡터를 다시 Rigidbody에 적용합니다.
        rb.velocity = velocity;
    }
}
