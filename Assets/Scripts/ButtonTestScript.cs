using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTestScript : MonoBehaviour
{

    public bool firstSpell, secondSpell;

    public void PickASpell()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (firstSpell = true)
        {
            Debug.Log("You chose " + name);

        }

        else if (secondSpell = true)
        {
            Debug.Log("You chose " + name);

           
        }

        }
    }
}