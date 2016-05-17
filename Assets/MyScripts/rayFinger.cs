using UnityEngine;
using System.Collections;
using Leap;

public class rayFinger : MonoBehaviour
{

    private GameObject button;
    private Animator anim;


    void Update()
    {
        GameObject RightHandController = GameObject.Find("Bip01 R Finger1Nub");

        if (RightHandController != null)//right finger direction of raycast
        {
            Ray ray = new Ray(RightHandController.transform.position, RightHandController.transform.TransformDirection(Vector3.right));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1))
            {


                if (hit.collider.gameObject.name == ("Button"))
                {

                    button = hit.collider.gameObject;


                    anim = button.GetComponent<Animator>();
                    anim.SetBool("Normal", false);
                    anim.SetBool("Highlighted", true);
                    Debug.DrawLine(ray.origin, hit.point);
                }
            }
        }
    }
}