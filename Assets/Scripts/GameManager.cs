using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text nick1;
    [SerializeField] Text nick2;
    // Start is called before the first frame update
    void Start()
    {
        nick1.text = Nickname.nickname1 == "" ? "Player 1" : Nickname.nickname1;
        nick2.text = Nickname.nickname2 == "" ? "Player 2" : Nickname.nickname2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
