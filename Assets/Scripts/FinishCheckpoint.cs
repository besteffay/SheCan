using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCheckpoint : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false;
  
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !levelCompleted)
        {
            
            finishSound.Play();
            levelCompleted = true;
            CompleteLevel();        //Invoke("CompleteLevel", 2f);
           
        }
    }

    private void CompleteLevel()
    {
        Debug.Log("assigning award");

        if(SceneManager.GetActiveScene().name == "Level01")
        {
            GameControl.control.astronautFinished = true;
            Debug.Log("astronaut finished");
        }
        else if(SceneManager.GetActiveScene().name == "Level02")
        {
            GameControl.control.firefighterFinished = true;
            Debug.Log("firefighter finished");
        }
        else if(SceneManager.GetActiveScene().name == "Test")
        {
            GameControl.control.firefighterFinished = true;
            Debug.Log("test finished");
        }
 
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
