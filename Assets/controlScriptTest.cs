using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlScriptTest : MonoBehaviour {

    // Use this for initialization
    public GameObject cv;
	void Start () {

        GameObject go = Instantiate(cv);
        go.GetComponentInChildren<TypeText>().showText("Hellow world to everyone");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
