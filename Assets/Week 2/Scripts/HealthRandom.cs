using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int maxHealth = 100;
    public int minHealth = 0;
    public int health = 0;


    //----------------------Edit above here --------------------
    void Start()
    {

            slider.minValue = minHealth;
            slider.maxValue = maxHealth;

    }
    private void Awake()
    {
        RandomHealth();
    }


    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public void RandomHealth()
    {
        this.health = Random.Range(minHealth, maxHealth + 1); 
        if (slider != null)
        {
            slider.value = health;
        }
    }
}
