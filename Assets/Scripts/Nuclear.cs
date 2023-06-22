using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuclear : MonoBehaviour
{
    public int target;
    [SerializeField] float speed;
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject explosion2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 90f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (target == 2)
        {
            transform.eulerAngles = new Vector3(0, 0, -90f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "Planet" + target.ToString())
        {
            Instantiate(explosion, transform.position, Quaternion.Euler(0, 0, GetAngle(other.transform.position, transform.position) - 90f));

            other.GetComponent<Planet>().Hp -= 15f;
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Meteor"))
        {
            Instantiate(explosion2, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    float GetAngle(Vector2 start, Vector2 end)
    {
        Vector2 v2 = end - start;
        return Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
    }

}
