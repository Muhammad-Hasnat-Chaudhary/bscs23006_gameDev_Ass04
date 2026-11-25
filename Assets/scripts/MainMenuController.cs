using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject levelSelectPanel;
    public GameObject settingsPanel;

    public TMP_Text musicText;
    public TMP_Text soundText;
    public TMP_Text qualityText;

    public AudioSource musicSource;

    private bool musicOn = true;
    private bool soundOn = true;
    private int qualityLevel;

    void Start()
    {
        qualityLevel = QualitySettings.GetQualityLevel();
        UpdateSettingsText();
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
        settingsPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void ShowSettings()
    {
        mainMenuPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ToggleMusic()
    {
        musicOn = !musicOn;

        if (musicSource != null)
            musicSource.mute = !musicOn;

        UpdateSettingsText();
    }

    public void ToggleSound()
    {
        soundOn = !soundOn;
        AudioListener.volume = soundOn ? 1f : 0f;
        UpdateSettingsText();
    }

    public void ChangeQuality()
    {
        qualityLevel++;

        if (qualityLevel >= QualitySettings.names.Length)
            qualityLevel = 0;

        QualitySettings.SetQualityLevel(qualityLevel);
        UpdateSettingsText();
    }

    private void UpdateSettingsText()
    {
        if (musicText != null)
            musicText.text = musicOn ? "MUSIC: ON" : "MUSIC: OFF";

        if (soundText != null)
            soundText.text = soundOn ? "SOUND: ON" : "SOUND: OFF";

        if (qualityText != null)
            qualityText.text = "QUALITY: " +
                QualitySettings.names[qualityLevel].ToUpper();
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