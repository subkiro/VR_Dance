using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    public void hardRestartGame()
    {
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
