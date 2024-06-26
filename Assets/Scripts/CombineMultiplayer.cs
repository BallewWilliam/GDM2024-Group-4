using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Timeline;


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
    public AudioSource StormSound;
    public AudioSource SteamSound;
    public AudioSource SteelSound;
    public AudioSource IceSound;
    public AudioSource FlamethrowerSound;
    public AudioSource TornadoSound;
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
        readyDisplayP1();
        readyDisplayP2();
        if (ready.P1Ready)
        {
            Debug.Log("Combine 1!");
            CombineP1();
            ready.P1Ready = false;
        }
        if (ready.P2Ready)
        {
            Debug.Log("Combine 2!");
            CombineP2();
            ready.P2Ready = false;
        }
        if (element_1_P1.text == element_2_P1.text)
        {
            P1_element2 = false;
        }
        if (element_1_P2.text == element_2_P2.text)
        {
            P2_element2 = false;
        }
    }
    void readyDisplayP1()
    {
        if (CombinationP1.text != "C")
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else
        {
            readysquare.color = Color.white;
            P1ReadyButton.SetActive(false);
        }
    }
    void readyDisplayP2()
    {
        if (CombinationP2.text != "C")
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else
        {
            readysquare.color = Color.white;
            P2ReadyButton.SetActive(false);
        }
    }
    public void DisplayP1()
    {
        if (airP1 && waterP1)
        {
            CombinationP1.text = "Storm";
            airP1 = false; 
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        else if (airP1 && earthP1)
        {
            CombinationP1.text = "Tornado";
            
            airP1 = false;
            earthP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        else if (airP1 && fireP1)
        { 
            CombinationP1.text = "Flamethrower";

            airP1 = false;
            fireP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        else if (fireP1 && waterP1)
        {
            CombinationP1.text = "Steam";

            fireP1 = false;
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        else if (earthP1 && waterP1)
        {
            CombinationP1.text = "Ice";

            earthP1 = false;
            waterP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
        else if (earthP1 && fireP1)
        {
            CombinationP1.text = "Steel";

            earthP1 = false;
            fireP1 = false;
            P1_element1 = false;
            P1_element2 = false;
        }
    }
    public void DisplayP2()
    {
        if (airP2 && waterP2)
        {
            CombinationP2.text = "Storm";

            waterP2 = false;
            airP2 = false;
            P2_element1 = false;
            P2_element2 = false;

        }
        else if (airP2 && earthP2)
        {
            CombinationP2.text = "Tornado";

            airP2 = false;
            earthP2 = false;
            P2_element1 = false;
            P2_element2 = false;

        }
        else if (airP2 && fireP2)
        {
            CombinationP2.text = "Flamethrower";

            airP2 = false;
            fireP2 = false;
            P2_element1 = false;
            P2_element2 = false;

        }
        else if (fireP2 && waterP2)
        {
            CombinationP2.text = "Steam";

            fireP2 = false;
            waterP2 = false;
            P2_element1 = false;
            P2_element2 = false;

        }
        else if (earthP2 && waterP2)
        {
            CombinationP2.text = "Ice";

            earthP2 = false;
            waterP2 = false;
            P2_element1 = false;
            P2_element2 = false;

        }
        else if (earthP2 && fireP2)
        {
            CombinationP2.text = "Steel";

            earthP2 = false;
            fireP2 = false;
            P2_element1 = false;
            P2_element2 = false;
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
        if (CombinationP1.text == "Storm")
        {
            CombinationP1.text = "C";

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
        if (CombinationP1.text == "Tornado")
        {
            CombinationP1.text = "C";
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
        if (CombinationP1.text == "Flamethrower")
        {
            CombinationP1.text = "C";
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
        if (CombinationP1.text == "Steam")
        {
            CombinationP1.text = "C";
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
        if (CombinationP1.text == "Ice")
        {
            CombinationP1.text = "C";
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
        if (CombinationP1.text == "Steel")
        {
            CombinationP1.text = "C";
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
        if (CombinationP2.text == "Storm")
        {
            CombinationP2.text = "C";
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
        if (CombinationP2.text == "Tornado")
        {
            CombinationP2.text = "C";
            Debug.Log("T2 True!");
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
        if (CombinationP2.text == "Flamethrower")
        {
            CombinationP2.text = "C";
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
        if (CombinationP2.text == "Steam")
        {
            CombinationP2.text = "C";
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
        if (CombinationP2.text == "Ice")
        {
            CombinationP2.text = "C";
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
        if (CombinationP2.text == "Steel")
        {
            CombinationP2.text = "C";
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
