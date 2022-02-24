using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Image HealthFill;
    public Image ManaFill;

    Color greenMax = Color.HSVToRGB(0.2495f,0.6986f,0.8588f);
    Color greenMin = Color.HSVToRGB(0.3704f,0.4821f,0.2196f);

    private Color blueMax = Color.HSVToRGB(0.4902f,1.0000f,1.0000f);
    private Color blueMin = Color.HSVToRGB(0.6089f,1.0000f,0.7804f);

    public void UpdateHealthBar(Single value)
    {
        HealthFill.color = Color.Lerp(greenMin, greenMax, value/100);
    }

    public void UpdateManaBar(Single value)
    {
        ManaFill.color = Color.Lerp(blueMin, blueMax, value/100);
    }
}