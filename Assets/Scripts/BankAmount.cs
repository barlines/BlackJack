using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BankAmount : MonoBehaviour
{
    public static int bankValue = 50;
    Text Bank;
    // Start is called before the first frame update
    void Start()
    {
        Bank = GetComponent<Text>();
        //count = GameManager.GetPlayerTotal(cards); 
    }

    // Update is called once per frameGameController
    void Update()
    {
        Bank.text = "Chip Amount: " + bankValue;
    }
}

