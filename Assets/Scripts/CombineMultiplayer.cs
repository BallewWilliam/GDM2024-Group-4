using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombineMultiplayer : MonoBehaviour
{
    public Image readysquare;
    public GameObject P1ReadyButton;
    public GameObject P2ReadyButton;
    public TMP_Text CombinationP1;
    public TMP_Text element_1_P1;
    public TMP_Text element_2_P1;
    public TMP_Text CombinationP2;
    public TMP_Text element_1_P2;
    public TMP_Text element_2_P2;
    public GameObject Manager;
    private Spell_Comparison spell;
    private MultiplayerManager ready;
    public bool P1_element1;
    public bool P1_element2;
    public bool P2_element1;
    public bool P2_element2;
    public bool airP1;
    public bool waterP1;
    public bool fireP1;
    public bool earthP1;
    public bool airP2;
    public bool waterP2;
    public bool fireP2;
    public bool earthP2;

    // Start is called before the first frame update
    void Start()
    {
        P1_element1 = false;
        P1_element2 = false;
        spell = Manager.GetComponent<Spell_Comparison>();
        ready = Manager.GetComponent<MultiplayerManager>();

    }

    private void FixedUpdate()
    {
        DisplayP1();
        DisplayP2();
        if (ready.P1Ready)
            CombineP1();
        if (ready.P2Ready)
            CombineP2();
        if (element_1_P1.text == element_2_P1.text)
        {
            P1_element2 = false;
        }
        if (element_1_P2.text == element_2_P2.text)
        {
            P2_element2 = false;
        }
    }

    public void DisplayP1()
    {
        if (airP1 && waterP1)
        {
            CombinationP1.text = "Storm";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (airP1 && earthP1)
        {
            CombinationP1.text = "Tornado";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (airP1 && fireP1)
        { 
            CombinationP1.text = "Flamethrower";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (fireP1 && waterP1)
        {
            CombinationP1.text = "Steam";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (earthP1 && waterP1)
        {
            CombinationP1.text = "Ice";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (earthP1 && fireP1)
        {
            CombinationP1.text = "Steel";
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else
        {
            readysquare.color = Color.white;
            P1ReadyButton.SetActive(false);
        }
    }
    public void DisplayP2()
    {
        if (airP2 && waterP2)
        {
            CombinationP2.text = "Storm";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);

        }
        else if (airP2 && earthP2)
        {
            CombinationP2.text = "Tornado";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);

        }
        else if (airP2 && fireP2)
        {
            CombinationP2.text = "Flamethrower";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);

        }
        else if (fireP2 && waterP2)
        {
            CombinationP2.text = "Steam";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);

        }
        else if (earthP2 && waterP2)
        {
            CombinationP2.text = "Ice";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);

        }
        else if (earthP2 && fireP2)
        {
            CombinationP2.text = "Steel";
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else
        {
            readysquare.color = Color.white;
            P2ReadyButton.SetActive(false);
        }
    }
    public void PrintFireP1()
    {
        fireP1 = true;
        if (!P1_element1)
        {
            element_1_P1.text = "Fire";
            P1_element1 = true;
            //Debug.Log("Element 1 true!");
        }
        else if (P1_element1 && !P1_element2)
        {
            element_2_P1.text = "Fire";
            P1_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintFireP2()
    {
        fireP2 = true;
        if (!P2_element1)
        {
            element_1_P2.text = "Fire";
            P2_element1 = true;
            //Debug.Log("Element 1 true!");
        }
        else if (P2_element1 && !P2_element2)
        {
            element_2_P2.text = "Fire";
            P2_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintWaterP1()
    {
        waterP1 = true;
        if (!P1_element1)
        {
            element_1_P1.text = "Water";
            P1_element1 = true;
        }
        else if (P1_element1 && !P1_element2)
        {
            element_2_P1.text = "Water";
            P1_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintWaterP2()
    {
        waterP2 = true;
        if (!P2_element1)
        {
            element_1_P2.text = "Water";
            P2_element1 = true;
        }
        else if (P2_element1 && !P2_element2)
        {
            element_2_P2.text = "Water";
            P2_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintEarthP1()
    {
        earthP1 = true;
        if (!P1_element1)
        {
            element_1_P1.text = "Earth";
            P1_element1 = true;
        }
        else if (P1_element1 && !P1_element2)
        {
            element_2_P1.text = "Earth";
            P1_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintEarthP2()
    {
        earthP2 = true;
        if (!P2_element1)
        {
            element_1_P2.text = "Earth";
            P2_element1 = true;
        }
        else if (P2_element1 && !P2_element2)
        {
            element_2_P2.text = "Earth";
            P2_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintAirP1()
    {
        airP1 = true;
        if (!P1_element1)
        {
            element_1_P1.text = "Air";
            P1_element1 = true;
        }
        else if (P1_element1 && !P1_element2)
        {
            element_2_P1.text = "Air";
            P1_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void PrintAirP2()
    {
        airP2 = true;
        if (!P2_element1)
        {
            element_1_P2.text = "Air";
            P2_element1 = true;
        }
        else if (P2_element1 && !P2_element2)
        {
            element_2_P2.text = "Air";
            P2_element2 = true;
            //Debug.Log("Element 2 true!");
        }
    }
    public void CombineP1()
    {
        if (airP1 && waterP1)
        {
            CombinationP1.text = "Storm";
            spell.Storm1 = true;
            spell.Tornado1 = false;
            spell.Flamethrower1 = false;
            spell.Steam1 = false;
            spell.Ice1 = false;
            spell.Steel1 = false;
            airP1 = false;
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        if (airP1 && earthP1)
        {
            CombinationP1.text = "Tornado";
            spell.Tornado1 = true;
            spell.Storm1 = false;
            spell.Flamethrower1 = false;
            spell.Steam1 = false;
            spell.Ice1 = false;
            spell.Steel1 = false;
            airP1 = false;
            earthP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        if (airP1 && fireP1)
        {
            CombinationP1.text = "Flamethrower";
            spell.Flamethrower1 = true;
            spell.Storm1 = false;
            spell.Tornado1 = false;
            spell.Steam1 = false;
            spell.Ice1 = false;
            spell.Steel1 = false;
            airP1 = false;
            fireP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        if (fireP1 && waterP1)
        {
            CombinationP1.text = "Steam";
            spell.Steam1 = true;
            spell.Storm1 = false;
            spell.Tornado1 = false;
            spell.Flamethrower1 = false;
            spell.Ice1 = false;
            spell.Steel1 = false;
            fireP1 = false;
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        if (earthP1 && waterP1)
        {
            CombinationP1.text = "Ice";
            spell.Ice1 = true;
            spell.Storm1 = false;
            spell.Tornado1 = false;
            spell.Flamethrower1 = false;
            spell.Steam1 = false;
            spell.Steel1 = false;
            earthP1 = false;
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        if (earthP1 && fireP1)
        {
            CombinationP1.text = "Steel";
            spell.Steel1 = true;
            spell.Storm1 = false;
            spell.Tornado1 = false;
            spell.Flamethrower1 = false;
            spell.Steam1 = false;
            spell.Ice1 = false;
            earthP1 = false;
            fireP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
    }
    public void CombineP2()
    {
        if (airP2 && waterP2)
        {
            CombinationP2.text = "Storm";
            spell.Storm2 = true;
            spell.Tornado2 = false;
            spell.Flamethrower2 = false;
            spell.Steam2 = false;
            spell.Ice2 = false;
            spell.Steel2 = false;
            airP2 = false;
            waterP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
        if (airP2 && earthP2)
        {
            CombinationP2.text = "Tornado";
            spell.Tornado2 = true;
            spell.Storm2 = false;
            spell.Flamethrower2 = false;
            spell.Steam2 = false;
            spell.Ice2 = false;
            spell.Steel2 = false;
            airP2 = false;
            earthP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
        if (airP2 && fireP2)
        {
            CombinationP2.text = "Flamethrower";
            spell.Flamethrower2 = true;
            spell.Storm2 = false;
            spell.Tornado2 = false;
            spell.Steam2 = false;
            spell.Ice2 = false;
            spell.Steel2 = false;
            airP2 = false;
            fireP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
        if (fireP2 && waterP2)
        {
            CombinationP2.text = "Steam";
            spell.Steam2 = true;
            spell.Storm2 = false;
            spell.Tornado2 = false;
            spell.Flamethrower2 = false;
            spell.Ice2 = false;
            spell.Steel2 = false;
            fireP2 = false;
            waterP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
        if (earthP2 && waterP2)
        {
            CombinationP2.text = "Ice";
            spell.Ice2 = true;
            spell.Storm2 = false;
            spell.Tornado2 = false;
            spell.Flamethrower2 = false;
            spell.Steam2 = false;
            spell.Steel2 = false;
            earthP2 = false;
            waterP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
        if (earthP2 && fireP2)
        {
            CombinationP2.text = "Steel";
            spell.Steel2 = true;
            spell.Storm2 = false;
            spell.Tornado2 = false;
            spell.Flamethrower2 = false;
            spell.Steam2 = false;
            spell.Ice2 = false;
            earthP2 = false;
            fireP2 = false;
            P2_element1 = false;
            P2_element2 = false;
        }
    }
}
