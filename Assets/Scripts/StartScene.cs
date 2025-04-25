using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject controlsPanel;
    public GameObject aboutPanel;

    // Called by Start Button
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads next scene
    }

    // Called by Quit Button
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!"); // Only works in build, not editor
    }

    // Called by Controls Button
    public void ShowControls()
    {
        mainMenuPanel.SetActive(false);
        controlsPanel.SetActive(true);
    }

    // Called by About Button
    public void ShowAbout()
    {
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    // Called by both close buttons
    public void ClosePanels()
    {
        controlsPanel.SetActive(false);
        aboutPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
