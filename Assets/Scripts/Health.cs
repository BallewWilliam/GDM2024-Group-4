using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100;
    public Button spellButton;

    private void Update()
    {

        if(healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void TakeDamage(float Damage)
    {
        Damage = 5;
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
    }

    public void OnSpellButtonClick()
    {
        Debug.Log ("Success");

    }
}
