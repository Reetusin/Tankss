using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Transform bar;

    public int maxHealth = 100;

    private int health;

    public bool isPlayer1 = true;

    private Player player;


    void Start()
    {
        player = GetComponent<Player>();
        health = maxHealth;

    }


    public void TakeDamage(int damage)
    {
        health -= damage;

        health = Mathf.Max(0, health);

        bar.localScale = new Vector3((float)health / maxHealth, 1, 1);

        if (health == 0)
        {
            if (isPlayer1)
            {
                SceneManager.LoadScene("Endd");
            }
            else
            {
                SceneManager.LoadScene("End");
            }

        }
    }

}