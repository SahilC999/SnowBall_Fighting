using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int maxHealth = 100;

    [Header("Players")]
    public PlayerController player1;
    public PlayerController player2;

    [Header("UI")]
    public Slider player1HealthBar;
    public Slider player2HealthBar;
    public GameObject gameOverPanel;
    public Text winnerText;

    private int player1Health;
    private int player2Health;
    private bool gameEnded = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        player1Health = maxHealth;
        player2Health = maxHealth;

        if (player1HealthBar) player1HealthBar.maxValue = maxHealth;
        if (player2HealthBar) player2HealthBar.maxValue = maxHealth;

        UpdateHealthUI();
    }

    public void DamagePlayer(string playerTag, int damage)
    {
        if (gameEnded) return;

        if (playerTag == "Player1")
        {
            player1Health -= damage;
            if (player1Health < 0) player1Health = 0;
        }
        else if (playerTag == "Player2")
        {
            player2Health -= damage;
            if (player2Health < 0) player2Health = 0;
        }

        UpdateHealthUI();
        CheckWinCondition();
    }

    void UpdateHealthUI()
    {
        if (player1HealthBar) player1HealthBar.value = player1Health;
        if (player2HealthBar) player2HealthBar.value = player2Health;
    }

    void CheckWinCondition()
    {
        if (player1Health <= 0)
        {
            EndGame("Player 2 Wins!");
        }
        else if (player2Health <= 0)
        {
            EndGame("Player 1 Wins!");
        }
    }

    void EndGame(string winner)
    {
        gameEnded = true;
        Debug.Log(winner);

        if (gameOverPanel) gameOverPanel.SetActive(true);
        if (winnerText) winnerText.text = winner;

        // Optionally disable player control
        player1.enabled = false;
        player2.enabled = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
