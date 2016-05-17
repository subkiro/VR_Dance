using UnityEngine;
using System.Collections;

public class rayPalm : MonoBehaviour {

    // Use this for initialization
    public bool iSeeMyPalm;
    
    void Update()
    {
    

    


        iSeeMyPalm= facelookHit();


}
    public bool facelookHit() {
        RaycastHit hit;
         
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 5000))
        {
            
            if (hit.collider.gameObject.name == ("CameraCube")) {
               
                Debug.DrawLine(transform.position, hit.point);
                return true;

            }

        }

        return false;
    }



}
