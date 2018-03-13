using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDialogPositionSet : MonoBehaviour {
    private RectTransform rt;
	// Use this for initialization
	void Start () {
        rt = this.gameObject.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector3(0, 0,0);
    }
	
	
}
