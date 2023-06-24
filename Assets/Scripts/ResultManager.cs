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
        loserText.text = GameManager.loser + "¿« «‡º∫¿Ã ∏Í∏¡«ﬂΩ¿¥œ¥Ÿ.";
    }

}
