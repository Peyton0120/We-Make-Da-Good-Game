using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //Sets the slider to max health
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //Sets the slider to current health of object
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
