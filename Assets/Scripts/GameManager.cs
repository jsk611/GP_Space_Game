using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text nick1;
    [SerializeField] Text nick2;

    [SerializeField] Planet p1;
    [SerializeField] Planet p2;

    public static string winner;
    public static string loser;
    // Start is called before the first frame update
    void Start()
    {
        nick1.text = Nickname.nickname1 == "" ? "Player 1" : Nickname.nickname1;
        nick2.text = Nickname.nickname2 == "" ? "Player 2" : Nickname.nickname2;
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.Hp <= 0)
        {
            winner = Nickname.nickname2;
            loser = Nickname.nickname1;
            SceneManager.LoadScene("ResultScene");
        }
        else if (p1.Hp <= 0)
        {
            loser = Nickname.nickname2;
            winner = Nickname.nickname1;
            SceneManager.LoadScene("ResultScene");
        }
    }
}
