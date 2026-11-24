
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject levelSelectPanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("LEVEL01");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowLevelSelect()
    {
        mainMenuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene("LEVEL01");
    }

    public void LoadLevel02()
    {
        SceneManager.LoadScene("LEVEL02");
    }

    public void LoadLevel03()
    {
        SceneManager.LoadScene("LEVEL03");
    }

    public void LoadLevel04()
    {
        SceneManager.LoadScene("LEVEL04");
    }

    public void LoadLevel05()
    {
        SceneManager.LoadScene("LEVEL05");
    }
}
