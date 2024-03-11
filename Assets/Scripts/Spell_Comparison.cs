using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spell_Comparison : MonoBehaviour
{
    public bool Steel1;
    public bool Steel2;
    public bool Tornado1;
    public bool Tornado2;
    public bool Steam1;
    public bool Steam2;
    public bool Flamethrower1;
    public bool Flamethrower2;
    public bool Ice1;
    public bool Ice2;
    public bool Storm1;
    public bool Storm2;
    public Image P1_Health;
    public Image P2_Health;
    public TMP_Text P1_Health_text;
    public TMP_Text P2_Health_text;
    public float P1_Health_Amount;
    public float P2_Health_Amount;

    private void FixedUpdate()
    {
        Compare();
        P1_Health_text.SetText(P1_Health_Amount.ToString());
        P2_Health_text.SetText(P2_Health_Amount.ToString());
    }   

    void Compare()
    {
        if (Steel1 &&  Steel2)
        {
            Steel1 = false;
            Steel2 = false;
        }
        if (Steel1 && Tornado2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            Steel1 = false;
            Tornado2 = false;
        }
        if (Steel1 && Steam2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steel1 = false;
            Steam2 = false;
        }
        if (Steel1 && Flamethrower2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steel1 = false;
            Flamethrower2 = false;
        }
        if (Steel1 && Ice2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steel1 = false;
            Ice2 = false;
        }
        if (Steel1 && Storm2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steel1 = false;
            Storm2 = false;
        }

        if (Tornado1 && Steel2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P2_Health_Amount / 10;
            Tornado1 = false;
            Steel2 = false;
        }
        if (Tornado1 && Tornado2)
        {
            Tornado1 = false;
            Tornado2 = false;
        }
        if (Tornado1 && Steam2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            Tornado1 = false;
            Steam2 = false;
        }
        if (Tornado1 && Flamethrower2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Tornado1 = false;
            Flamethrower2 = false;
        }
        if (Tornado1 && Ice2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Tornado1 = false;
            Ice2 = false;
        }
        if (Tornado1 && Storm2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Tornado1 = false;
            Storm2 = false;
        }

        if (Steam1 && Steel2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steam1 = false;
            Steel2 = false;
        }
        if (Steam1 && Tornado2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steam1 = false;
            Tornado2 = false;
        }
        if (Steam1 && Steam2)
        {
            Steam1 = false;
            Steam2 = false;
        }
        if (Steam1 && Flamethrower2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            Steam1 = false;
            Flamethrower2 = false;
        }
        if (Steam1 && Ice2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steam1 = false;
            Ice2 = false;
        }
        if (Steam1 && Storm2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Steam1 = false;
            Storm2 = false;
        }

        if (Flamethrower1 && Steel2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Flamethrower1 = false;
            Steel2 = false;
        }
        if (Flamethrower1 && Tornado2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Flamethrower1 = false;
            Tornado2 = false;
        }
        if (Flamethrower1 && Steam2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Flamethrower1 = false;
            Steam2 = false;
        }
        if (Flamethrower1 && Flamethrower2)
        {
            Flamethrower1 = false;
            Flamethrower2 = false;
        }
        if (Flamethrower1 && Ice2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P1_Health_Amount / 10;
            Flamethrower1 = false;
            Ice2 = false;
        }
        if (Flamethrower1 && Storm2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Flamethrower1 = false;
            Storm2 = false;
        }

        if (Ice1 && Steel2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Ice1 = false;
            Steel2 = false;
        }
        if (Ice1 && Tornado2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Ice1 = false;
            Tornado2 = false;
        }
        if (Ice1 && Steam2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Ice1 = false;
            Steam2 = false;
        }
        if (Ice1 && Flamethrower2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Ice1 = false;
            Flamethrower2 = false;
        }
        if (Ice1 && Ice2)
        {
            Ice1 = false;
            Ice2 = false;
        }
        if (Ice1 && Storm2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P1_Health_Amount / 10;
            Ice1 = false;
            Storm2 = false;
        }

        if (Storm1 && Steel2)
        {
            P2_Health_Amount -= 2f;
            P2_Health.fillAmount = P1_Health_Amount / 10;
            Storm1 = false;
            Steel2 = false;
        }
        if (Storm1 && Tornado2)
        {
            P2_Health_Amount -= 1.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 0.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Storm1 = false;
            Tornado2 = false;
        }
        if (Storm1 && Steam2)
        {
            P2_Health_Amount -= 1f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Storm1 = false;
            Steam2 = false;
        }
        if (Storm1 && Flamethrower2)
        {
            P2_Health_Amount -= 0.5f;
            P2_Health.fillAmount = P2_Health_Amount / 10;
            P1_Health_Amount -= 1.5f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Storm1 = false;
            Flamethrower2 = false;
        }
        if (Storm1 && Ice2)
        {
            P1_Health_Amount -= 2f;
            P1_Health.fillAmount = P1_Health_Amount / 10;
            Storm1 = false;
            Ice2 = false;
        }
        if (Storm1 && Storm2)
        {
            Storm1 = false;
            Storm2 = false;
        }

    }

    public void Steel1T()
    { 
        Steel1 = true;

    }
    public void Steel2T() 
    {
        Steel2 = true;
    }
    public void Tornado1T()
    {
        Tornado1 = true;
    }
    public void Tornado2T()
    {
        Tornado2 = true;
    }
    public void Steam1T()
    {
        Steam1 = true;
    }
    public void Steam2T()
    {
        Steam2 = true;
    }
    public void Flamethrower1T()
    {
        Flamethrower1 = true;
    }
    public void Flamethrower2T()
    {
        Flamethrower2 = true;
    }
    public void Ice1T()
    {
        Ice1 = true;
    }
    public void Ice2T()
    {
        Ice2 = true;
    }
    public void Storm1T()
    {
        Storm1 = true;
    }
    public void Storm2T()
    {
        Storm2 = true;
    }


}
