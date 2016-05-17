using UnityEngine;
using System.Collections;

public class RayFromPalm : MonoBehaviour {
    private GameObject LeftHandController;
    public bool iSeeMyPalm;
    // Use this for initialization

    void Start () {
  

    }
	
	// Update is called once per frame
	void Update () {
        iSeeMyPalm =  facelookHit();
    }

    public bool facelookHit()
    {

        GameObject LeftHandController = GameObject.Find("PepperLightFullLeftHand(Clone)/HandContainer");

        if (LeftHandController != null) { 
   
        RaycastHit hit;
           
            if (Physics.Raycast(LeftHandController.transform.position, LeftHandController.transform.TransformDirection(Vector3.down), out hit, 50))
            {

                        if (hit.collider.gameObject.name == ("CameraCube"))
                        {
                            Debug.DrawLine(LeftHandController.transform.position, hit.point);
                            return true;

                        }

            }
        }

        return false;
    }

}
