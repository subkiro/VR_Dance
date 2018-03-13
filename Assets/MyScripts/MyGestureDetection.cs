using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGestureDetection : MonoBehaviour {
    public AudioClip[] otherClip;
    private new AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = otherClip[0];


    }

    public void onThumbActivatePlaySound() {
           
        GoToNextStageTutorial();
        audio.Play();
    }
    public void onThumbDeActivatePlaySound()
    {

    }

    public void GoToNextStageTutorial() {
       GetComponent<TutorialStageScript>().GoToNextStage();
    }

    

  
}
