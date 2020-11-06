using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarEnemy : MonoBehaviour
{
    private Slider healthBar;
    private int maxHealth = 100;
    private int currentHP = 100;

    private void Awake()
    {
        healthBar = GetComponent<Slider>();
    }


    void Update()
    {
        if (currentHP > maxHealth)
        {
            currentHP = maxHealth;
        }
        if (currentHP <= 0)
        {
            Application.Quit();
        }
        healthBar.value = currentHP;
    }

    public int CurrentHealth()
    {
        return currentHP;
    }

    public void ChangeHealthProgress(int dHP)
    {
        currentHP += dHP;
    }
}
