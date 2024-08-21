using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//한글

public class GameDirector : MonoBehaviour
{
    public Image hpGaueg;

    public void UpdateHpGauge(float fillAmaount)
    {
        this.hpGaueg.fillAmount= fillAmaount;
    }
}
