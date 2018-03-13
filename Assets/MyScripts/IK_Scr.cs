using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IK_Scr : MonoBehaviour {


    public bool ikActive = false;
     
    public Transform rightHandTarget_IK = null;
    public Transform leftHandTarget_IK = null;
    public Transform lookObj = null;

    public bool leftIKEnabled = false;
    public bool rightIKEnabled = false;


    protected  Animator animator;



    public float offsetY;


    public float lookIKWeight;
    public float eyesWeight;
    public float headWeight;
    public float bodyWeight;
    public float clampWeight;

 
    public float leftHandWeight_rot;
    public float rightHandWeight_rot;


    public float TrunFloat;
    public float sideStepsFloat;

    // Use this for initialization

    void Start () {
        animator = GetComponent<Animator>();
        sideStepsFloat = 0;
        TrunFloat = 0;
                //Hand IK


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LeftSphere"))
        {
           // rightHandTarget_IK.position = other.gameObject.transform.position;
            this.rightIKEnabled = true;
            animator.SetBool("RiseRightHand", true);
        }


        if (other.CompareTag("RightSphere"))
        {
          //  leftHandTarget_IK.position = other.gameObject.transform.position;
            this.leftIKEnabled = true;
            animator.SetBool("RiseLeftHand", true);
           
        }


    }



    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeftSphere"))
        {
            this.rightIKEnabled = false;
            animator.SetBool("RiseRightHand", false);
        }


        if (other.CompareTag("RightSphere"))
        {
          
          this.leftIKEnabled = false;

            animator.SetBool("RiseLeftHand", false);

        }
    }


    // Update is called once per frame






    //a callback for calculating IK
    void OnAnimatorIK() {



        if (animator)
        {

            //hands weight

             
            //if the IK is active, set the position and rotation directly to the goal. 
            if (ikActive)
            {
                // Set the look target position, if one has been assigned


                float leftHandWeight_pos = animator.GetFloat("LeftHand");
                float rightHandWeight_pos = animator.GetFloat("RightHand");
                float lefthandWeightDon = animator.GetFloat("LeftHandDown");

                if (lookObj != null)
                {
                    animator.SetLookAtWeight(lookIKWeight, bodyWeight, headWeight, eyesWeight, clampWeight);
                    animator.SetLookAtPosition(lookObj.position);
                }

                // Set the right hand target position and rotation, if one has been assigned
               if ( rightIKEnabled )
               {
                    //this is for reactin in leap hand controls

                    
                    sideStepsFloat = (transform.position - rightHandTarget_IK.position).x;
                    TrunFloat = (transform.position - rightHandTarget_IK.position).y;
                   
                       
                    
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight_pos);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight_rot);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTarget_IK.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTarget_IK.rotation);
               }else {
                    
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, lefthandWeightDon);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, lefthandWeightDon);
                 }


                if (leftIKEnabled)
              {
                    

                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandWeight_pos);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandWeight_rot);
                    animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandTarget_IK.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandTarget_IK.rotation);
              }else {
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, lefthandWeightDon);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, lefthandWeightDon);
                   
                }



            }
            //if the IK is not active, set the position and rotation of the hand and head back to the original position
            else {
                
                animator.SetLookAtWeight(0);
            }

        }

    }

}
