using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerManager : MonoBehaviour
{
    public GameObject Manager;
    public Image readysquare;
    public GameObject P1Assets;
    public GameObject P2Assets;
    public GameObject P1ReadyButton;
    public GameObject P2ReadyButton;
    public Spell_Comparison spell;
    public bool P1Ready;
    public bool P2Ready;
    void Start()
    {
        spell = Manager.GetComponent<Spell_Comparison>();
        P1Ready = false;
        P2Ready = false;
    }

    void FixedUpdate()
    {
        //P1Turn();
        //P2Turn();
        if (P1Ready)
        {
            P1Assets.SetActive(false);
            P2Assets.SetActive(true);
            P1Ready = false;
        }
        if (P2Ready)
        {
            P2Assets.SetActive(false);
            P1Assets.SetActive(true);
            P2Ready = false;
        }

    }
    public void P1Turn()
    {
        if (spell.Steel1)
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (spell.Tornado1)
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (spell.Steam1)
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (spell.Flamethrower1)
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (spell.Ice1)
        {
            readysquare.color = Color.green;
            P1ReadyButton.SetActive(true);
        }
        else if (spell.Storm1)
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
    public void P2Turn()
    {
        if (spell.Steel2)
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else if (spell.Tornado2)
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else if (spell.Steam2)
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else if (spell.Flamethrower2)
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else if (spell.Ice2)
        {
            readysquare.color = Color.green;
            P2ReadyButton.SetActive(true);
        }
        else if (spell.Storm2)
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
    public void ReadyButtonP1()
    {
        P1Ready = true;
    }
    public void ReadyButtonP2()
    {
        P2Ready = true;
    }
}
