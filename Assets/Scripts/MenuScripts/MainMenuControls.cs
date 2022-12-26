using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;
    public int loadScene;
    public int loadLives;
    public int loadScore;
    public int loadAmmo;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }

    public void ResetGame()
    {
        clickSound.Play();
        PlayerPrefs.SetInt("SceneToLoad", 0);
        PlayerPrefs.SetInt("LivesSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("AmmoSaved", 0);
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad");
        if (loadScene == 0)
        {

        }
        else
        {
            StartCoroutine(LoadGameRoutine());
        }
    }

    IEnumerator LoadGameRoutine()
    {
        loadLives = PlayerPrefs.GetInt("LivesSaved");
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadAmmo = PlayerPrefs.GetInt("AmmoSaved");
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        GlobalComplete.nextFloor = loadScene;
        GlobalLife.lifeValue = loadLives;
        GlobalScore.scoreValue = loadScore;
        GlobalAmmo.pistolAmmo = loadAmmo;
        SceneManager.LoadScene(loadScene);
    }

    public void CreditButton()
    {
        clickSound.Play();
        SceneManager.LoadScene(5);
    }
}
