using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject instructionsPanel;
    public GameObject quitConfirmPanel;
    public AudioSource hoverSound;
    public AudioSource clickSound;
    public Animator transitionAnimator;
    public string gameSceneName = "GameScene";

    void Start()
    {
        Time.timeScale = 1f;
        instructionsPanel.SetActive(false);
        quitConfirmPanel.SetActive(false);
    }

    public void OnHover()
    {
        if (hoverSound != null) hoverSound.Play();
    }

    public void OnClick()
    {
        if (clickSound != null) clickSound.Play();
    }

    public void PlayGame()
    {
        OnClick();
        StartCoroutine(LoadSceneWithFade(gameSceneName));
    }

    public void ShowInstructions()
    {
        OnClick();
        instructionsPanel.SetActive(true);
    }

    public void HideInstructions()
    {
        OnClick();
        instructionsPanel.SetActive(false);
    }

    public void ConfirmQuit()
    {
        OnClick();
        quitConfirmPanel.SetActive(true);
    }

    public void CancelQuit()
    {
        OnClick();
        quitConfirmPanel.SetActive(false);
    }

    public void QuitGame()
    {
        OnClick();
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void OpenSettings()
    {
        OnClick();
        Debug.Log("Settings screen will be added soon.");
    }

    IEnumerator LoadSceneWithFade(string sceneName)
    {
        if (transitionAnimator != null)
        {
            transitionAnimator.SetTrigger("StartFade");
            yield return new WaitForSeconds(1f); // Adjust with animation duration
        }
        SceneManager.LoadScene(sceneName);
    }
}
