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
        if(p1.Hp <= 0.1f)
        {
            Debug.Log("게임끝");
            winner = nick2.text;
            loser = nick1.text;
            SceneManager.LoadScene("ResultScene");
        }
        else if (p2.Hp <= 0.1f)
        {
            Debug.Log("게임끝");
            loser = nick2.text;
            winner = nick1.text;
            SceneManager.LoadScene("ResultScene");
        }
    }
}
