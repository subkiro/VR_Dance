using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TypeText : MonoBehaviour {
    private string textiIn;
    private float delay = 0.1f;

    new AudioSource audio;
    public AudioClip _clip;
    // Use this for initialization


    public void showText( string textInput) {
        textiIn = textInput;
        StartCoroutine("ShowText");
    }

  



    public void PlayTypingSound()
    {
        audio.PlayOneShot(_clip, 0.1f);
       
    }

    IEnumerator ShowText()
    { 
        string currentText = "";
        audio = GetComponent<AudioSource>();
        foreach (char letter in textiIn.ToCharArray())
        {
            PlayTypingSound();

            currentText += letter;
            GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);



        }


    }
}
