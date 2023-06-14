using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelmetChanges : MonoBehaviour
{
    public Image astronautPortrait;
    public Image firefighterPortrait;
    //public Sprite astronautCasualPortrait;
    public Sprite astronautHelmetPortrait;
    //public Sprite firefighterCasualPortrait;
    public Sprite firefightertHelmetPortrait;

    private void Update()
    {
        if(GameControl.control.astronautFinished == true)
        {
            astronautPortrait.GetComponent<Image>().sprite = astronautHelmetPortrait;
        }

        if(GameControl.control.firefighterFinished == true)
        {
            firefighterPortrait.GetComponent<Image>().sprite = firefightertHelmetPortrait;
        }

    }
}
