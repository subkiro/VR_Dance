using UnityEngine;
using System.Collections;

public class ButtonQuit : MonoBehaviour {
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }

    }


	// Use this for initialization
	public void Quit () {
         UnityEditor.EditorApplication.isPlaying = false;

    }
	

}
