using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VictoryControl : MonoBehaviour
{
    public GameObject Manager;
    private Spell_Comparison health;
    public GameObject EndScreen;
    public TMP_Text VictoryText;

    private void Start()
    {
        health = GetComponent<Spell_Comparison>();
    }
    void FixedUpdate()
    {
        if (health.P1_Health_Amount <= 0 && health.P2_Health_Amount <= 0)
        {
            EndScreen.SetActive(true);
            VictoryText.text = "It's a Tie!!!";
        }
        if (health.P1_Health_Amount <= 0)
        {
            EndScreen.SetActive(true);
            VictoryText.text = "Player 2 Wins!!!";
        }
        if (health.P2_Health_Amount <= 0)
        {
            EndScreen.SetActive(true);
            VictoryText.text = "Player 1 Wins!!!";
        }
    }
}
