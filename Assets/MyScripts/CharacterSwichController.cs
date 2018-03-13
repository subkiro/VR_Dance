using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwichController : MonoBehaviour {

    public GameObject josePrefab;
    public GameObject beataPrefab;
    private GameObject activeAvatar;

    public Transform LeftHandTarget_IK;
    public Transform RightHandTarget_IK;
    public Transform LookObj;




    // Use this for initialization
    void Start () {

    }

    public void SwitchAvatarToBeata() {

        

        activeAvatar = GameObject.FindGameObjectWithTag("Character");
        Destroy(activeAvatar);
        activeAvatar = Instantiate(beataPrefab);
        activeAvatar.name = "Avatar";
        GetComponent<TutorialStageScript>().character = activeAvatar;
        GetComponent<CharacterMechanics>().Avatar = activeAvatar;
        GetComponent<CharacterMechanics>().initNavMesh();
        activeAvatar.GetComponent<IK_Scr>().rightHandTarget_IK = LeftHandTarget_IK;
        activeAvatar.GetComponent<IK_Scr>().leftHandTarget_IK = RightHandTarget_IK;
        activeAvatar.GetComponent<IK_Scr>().lookObj = LookObj;
        







    }


    public void SwitchAvatarToJose()
    {

        activeAvatar = GameObject.FindGameObjectWithTag("Character");
        Destroy(activeAvatar);
        activeAvatar = Instantiate(josePrefab);
        activeAvatar.name = "Avatar";
        GetComponent<TutorialStageScript>().character = activeAvatar;
        GetComponent<CharacterMechanics>().Avatar = activeAvatar;
        GetComponent<CharacterMechanics>().initNavMesh();
        activeAvatar.GetComponent<IK_Scr>().rightHandTarget_IK = LeftHandTarget_IK;
        activeAvatar.GetComponent<IK_Scr>().leftHandTarget_IK = RightHandTarget_IK;
        activeAvatar.GetComponent<IK_Scr>().lookObj = LookObj;







    }


    // Update is called once per frame
    void Update () {
		
	}
}
