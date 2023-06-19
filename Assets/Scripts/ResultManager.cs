using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text winnerText;
    [SerializeField] Text loserText;
    // Start is called before the first frame update
    void Start()
    {
        winnerText.text = GameManager.winner;
        loserText.text = "당신으로 인해 " + GameManager.loser + "의 행성이 멸망했습니다.";
    }

}
