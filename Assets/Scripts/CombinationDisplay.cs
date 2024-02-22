using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombinationDisplay : MonoBehaviour
{
    public TMP_Text element;
    public TMP_Text element_1;
    public TMP_Text element_2;
    public bool element1;
    public bool element2;
    public bool air;
    public bool water;
    public bool fire;
    public bool earth;

    // Start is called before the first frame update
    void Start()
    {
        element1 = false; element2 = false;
        element = GetComponent<TextMeshProUGUI>();

    }

    private void FixedUpdate()
    {
        Combine();
    }

    public void PrintFire()
    {
        fire = true;
        if (!element1)
        {
            element_1.text = "Fire";
            element1 = true;
            Debug.Log("Element 1 true!");
        }
        else if (element1 && !element2)
        {
            element_2.text = "Fire";
            element2 = true;
            Debug.Log("Element 2 true!");
        }
    }
    public void PrintWater()
    {
        water = true;
        if (!element1)
        {
            element_1.text = "Water";
            element1 = true;
        }
        else if (element1 && !element2)
        {
            element_2.text = "Water";
            element2 = true;
            Debug.Log("Element 2 true!");
        }
    }
    public void PrintEarth()
    {
        earth = true;
        if (!element1)
        {
            element_1.text = "Earth";
            element1 = true;
        }
        else if (element1 && !element2)
        {
            element_2.text = "Earth";
            element2 = true;
            Debug.Log("Element 2 true!");
        }
    }
    public void PrintAir()
    {
        air = true;
        if (!element1)
        {
            element_1.text = "Air";
            element1 = true;
        }
        else if (element1 && !element2)
        {
            element_2.text = "Air";
            element2 = true;
            Debug.Log("Element 2 true!");
        }
    }
    public void Combine()
    {
        if (air && water)
        {
            element.text = "Lightning";
            air = false;
            water = false;
            element1 = false; element2 = false;
        }
        if (air && earth)
        {
            element.text = "Tornado";
            air = false;
            earth = false;
            element1 = false; element2 = false;
        }
        if (air && fire)
        {
            element.text = "Flamethrower";
            air = false;
            fire = false;
            element1 = false; element2 = false;
        }
        if (fire && water)
        {
            element.text = "Steam";
            fire = false;
            water = false;
            element1 = false; element2 = false;
        }
        if (earth && water)
        {
            element.text = "Ice";
            earth = false;
            water = false;
            element1 = false; element2 = false;
        }
        if (earth && fire)
        {
            element.text = "Steel";
            earth = false;
            fire = false;
            element1 = false; element2 = false;
        }
    }
}
