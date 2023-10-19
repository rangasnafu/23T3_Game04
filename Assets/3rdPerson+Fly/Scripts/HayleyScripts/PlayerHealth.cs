using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject gameOverUI;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealht(maxHealth);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Debug.Log("hit by bullet, -1 health");
        }
    }
}
