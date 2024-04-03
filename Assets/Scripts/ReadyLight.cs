using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;


public class ReadyLight : MonoBehaviour
{
    public Image readysquare;
    public GameObject Manager;
    public GameObject ReadyButton;
    private Spell_Comparison spell;
    void Start()
    {
        spell = Manager.GetComponent<Spell_Comparison>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ReadyFunction();
    }
    void ReadyFunction()
    {
        if (spell.Steel1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else if (spell.Tornado1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else if (spell.Steam1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else if (spell.Flamethrower1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else if (spell.Ice1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else if (spell.Storm1)
        {
            readysquare.color = Color.green;
            ReadyButton.SetActive(true);
        }
        else
        {
            readysquare.color = Color.white;
            ReadyButton.SetActive(false);
        }
    }
}
