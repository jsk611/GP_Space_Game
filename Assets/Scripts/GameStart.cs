using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    [SerializeField] Text nick1;
    [SerializeField] Text nick2;

    public void SceneChange() {
        Nickname.nickname1 = nick1.text;
        Nickname.nickname2 = nick2.text;

        SceneManager.LoadScene("GameScene");
    }
}
