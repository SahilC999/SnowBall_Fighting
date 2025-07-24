using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public AudioSource clickSound;

    private bool isPaused = false;

    void Start()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void ResumeGame()
    {
        if (clickSound != null) clickSound.Play();
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartGame()
    {
        if (clickSound != null) clickSound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitToMenu()
    {
        if (clickSound != null) clickSound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Replace with your menu scene name
    }

    void PauseGame()
    {
        if (clickSound != null) clickSound.Play();
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
