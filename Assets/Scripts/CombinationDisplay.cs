using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombinationDisplay : MonoBehaviour
{
    public TMP_Text element;
    public List<string> tags;
    public GameObject Fire;
    public GameObject Water;
    public GameObject Earth;
    public GameObject Air;
    public bool air;
    public bool water;
    public bool fire;
    public bool earth;

    // Start is called before the first frame update
    void Start()
    {
        element = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        Combine();
    }

    public void PrintFire()
    {
        fire = true;
        element.text = "Fire";
    }
    public void PrintWater()
    {
        water = true;
        element.text = "Water";
    }
    public void PrintEarth()
    {
        earth = true;
        element.text = "Earth";
    }
    public void PrintAir()
    {
        air = true;
        element.text = "air";
    }
    public void Combine()
    {
        if (air && water)
        {
            element.text = "Lightning";
            air = false;
            water = false;
        }
        if (air && earth)
        {
            element.text = "Tornado";
            air = false;
            earth = false;
        }
        if (air && fire)
        {
            element.text = "Flamethrower";
            air = false;
            fire = false;
        }
        if (fire && water)
        {
            element.text = "Steam";
            fire = false;
            water = false;
        }
        if (earth && water)
        {
            element.text = "Ice";
            earth = false;
            water = false;
        }
        if (earth && fire)
        {
            element.text = "Steel";
            earth = false;
            fire = false;
        }
    }
}
