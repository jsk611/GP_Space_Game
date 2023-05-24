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
        // ���� �ӵ� ���͸� �����ɴϴ�.
        Vector3 velocity = rb.velocity;

        // �ӵ� ������ ���̰� �ִ� �ӵ����� ū ���, ���̸� �ִ� �ӵ��� �����մϴ�.
        if (velocity.magnitude > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed;
        }

        // ���ѵ� �ӵ� ���͸� �ٽ� Rigidbody�� �����մϴ�.
        rb.velocity = velocity;
    }
}
