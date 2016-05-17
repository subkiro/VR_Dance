using UnityEngine;
using System.Collections;

public class rayFinger : MonoBehaviour {

    void Update()
    {

        if (name == "Bip01 R Finger1Nub001")//right finger direction of raycast
        {
            Ray ray =  new Ray(transform.position, transform.TransformDirection(Vector3.left));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1))
                Debug.DrawLine(ray.origin, hit.point);
            //print("Hit something!" + "with finger: " + name);
        }


        else //left finger direction of raycast
        {
            Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.right));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1))
                Debug.DrawLine(ray.origin, hit.point);
                //print("Hit something!" + "with finger: " + name);
        }
    }
}