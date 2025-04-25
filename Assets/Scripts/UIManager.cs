using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameScreenPanel;
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    private bool isPaused = false;

    void Start()
    {
        ShowGameUI(); // Show Game UI at start
        Time.timeScale = 1f;
    }

    // Called when player presses pause button
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        gameScreenPanel.SetActive(false);
        pausePanel.SetActive(true);
    }

    // Called by resume button
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        gameScreenPanel.SetActive(true);
    }

    // Called when player dies (from GameManager)
    public void ShowGameOverUI()
    {
        Time.timeScale = 0f;
        gameScreenPanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    // Called by replay button
    public void ReplayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Called by quit button
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!"); // For testing in editor
    }

    public void ShowGameUI()
    {
        gameScreenPanel.SetActive(true);
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }
}
