using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public void OnClickExit() {
        Application.Quit();
        Debug.Log("Exit");
    }
}
