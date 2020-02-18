using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerTotal : MonoBehaviour
{
    public GameObject BustText;
    public static int scoreValue = 0;
    Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
        //count = GameManager.GetPlayerTotal(cards); 
    }

    // Update is called once per frameGameController
    void Update()
    {
        Score.text = "Player Total: " + scoreValue;
        if (scoreValue > 22)
        {
            BustText.active = true;
        }
    }
}
