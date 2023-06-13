using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private GameObject ChooseCanvas;
    [SerializeField] private GameObject AboutCanvas;
    [SerializeField] private GameObject HowtoplayCanvas;
    [SerializeField] private GameObject HomeCanvas;

    public SoundManager SoundManagerScript;

    public void Choose()
    {
        SoundManagerScript.PlayClickSound();
        ChooseCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
        HowtoplayCanvas.SetActive(false);
        HomeCanvas.SetActive(false);
    }

    public void Back()
    {
        SoundManagerScript.PlayClickSound();
        ChooseCanvas.SetActive(false);
        AboutCanvas.SetActive(false);
        HowtoplayCanvas.SetActive(false);
        HomeCanvas.SetActive(true);
        //   Time.timeScale = 1f;

    }
    public void Quit()
    {
        SoundManagerScript.PlayClickSound();
        Application.Quit();
        Debug.Log("QUIT");
    }

    public void Home()
    {
        SoundManagerScript.PlayClickSound();
        ChooseCanvas.SetActive(false);
        AboutCanvas.SetActive(false);
        HowtoplayCanvas.SetActive(false);
        HomeCanvas.SetActive(true);
    }

    public void About()
    {
        SoundManagerScript.PlayClickSound();
        ChooseCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
        HowtoplayCanvas.SetActive(false);
        HomeCanvas.SetActive(false);
    }

    public void HTP()
    {
        SoundManagerScript.PlayClickSound();
        ChooseCanvas.SetActive(false);
        AboutCanvas.SetActive(false);
        HowtoplayCanvas.SetActive(true);
        HomeCanvas.SetActive(false);
    }

    public void LoadLevel1(string Level01)
    {
        // Debug.Log("sceneName to load: " + Level01);
        SoundManagerScript.PlayClickSound();
        SceneManager.LoadScene(Level01);
    }

    public void LoadLevel2(string Level02)
    {
        //  Debug.Log("sceneName to load: " + Level02);
        SoundManagerScript.PlayClickSound();
        SceneManager.LoadScene(Level02);
    }
}