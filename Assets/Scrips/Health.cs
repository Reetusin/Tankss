using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Transform bar;

    public int maxHealth = 100;

    public int health;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Max(0, health);

        bar.transform.localScale = new Vector3((float)health / maxHealth, 1, 1);

        if (health == 0)
        {
            print("aw shucks");
        }
    }
}
