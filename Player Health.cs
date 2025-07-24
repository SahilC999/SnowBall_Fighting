using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Image[] healthBars; // Optional UI: 5 icons like candy canes

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }

        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthBars == null) return;
        int activeBars = currentHealth / 20;

        for (int i = 0; i < healthBars.Length; i++)
        {
            healthBars[i].enabled = i < activeBars;
        }
    }

    void Die()
    {
        // Optional: play death animation or restart
        Debug.Log(gameObject.name + " died!");
        gameObject.SetActive(false);
    }
}
