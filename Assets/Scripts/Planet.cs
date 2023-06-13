using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    [SerializeField] float maxHp;
    float hp;
    [SerializeField] Material material;

    [SerializeField] Image hpBar;
    public float Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
            if (hp >= maxHp) hp = maxHp;
            if (hp <= 0) hp = 0;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);

        hpBar.fillAmount = hp / maxHp;

        material.color = new Color(1, hp / maxHp, hp / maxHp);
    }

}
