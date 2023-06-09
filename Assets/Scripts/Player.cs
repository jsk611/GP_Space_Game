using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float force;
    public float maxSpeed;
    public Rigidbody rb;

    [SerializeField] Player1Move p1m;
    [SerializeField] Player2Move p2m;
    float h = 0;
    float v = 0;

    [SerializeField] Image mf;
    bool hasCoil;
    [SerializeField] GameObject nuclear;
    [SerializeField] GameObject empParticle;
    bool isDamagedEmp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0) transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        if (rb.velocity.x < 0) transform.localScale = new Vector3(0.5f, -0.5f, 1f);

        if (isDamagedEmp) StartCoroutine(DamagedEMP());
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
        hasCoil = true;

        rb.mass = 150f;
        mf.color = new Color(1, 0.75f, 0, 40f/255);

        if (p1m != null) p1m.force = 15000f;
        if (p2m != null) p2m.force = 15000f;

        yield return new WaitForSeconds(5f);

        rb.mass = 50f;
        mf.color = new Color(140f/255,140f/255,140f/255, 40f / 255);

        if (p1m != null) p1m.force = 4000f;
        if (p2m != null) p2m.force = 4000f;

        hasCoil = false;
    }

    IEnumerator DamagedEMP()
    {
        isDamagedEmp = false;
        maxSpeed /= 5f;
        empParticle.SetActive(true);
        yield return new WaitForSeconds(3f);
        empParticle.SetActive(false);
        maxSpeed *= 5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coil"))
        {
            if (!hasCoil)
            {
                StartCoroutine(CoilEffect());
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("Missile"))
        {
            if(p2m == null)//자신이 플레이어 1일때
            {
                Nuclear n = Instantiate(nuclear, new Vector3(-19f, Random.Range(-7.5f, 7.5f), 0), Quaternion.identity).GetComponent<Nuclear>();
                n.target = 2;
            }

            else if(p1m == null)//자신이 플레이어 2일때
            {
                Nuclear n = Instantiate(nuclear, new Vector3(19f, Random.Range(-7.5f, 7.5f), 0), Quaternion.identity).GetComponent<Nuclear>();
                n.target = 1;
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("EMP"))
        {
            if (p2m == null)//자신이 플레이어 1일때
            {
                FindObjectOfType<Player2Move>().gameObject.GetComponent<Player>().isDamagedEmp = true;
            }

            else if (p1m == null)//자신이 플레이어 2일때
            {
                FindObjectOfType<Player1Move>().gameObject.GetComponent<Player>().isDamagedEmp = true;
            }
            Destroy(other.gameObject);
        }
    }
}
