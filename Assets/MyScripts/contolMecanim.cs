using UnityEngine;
using System.Collections;

public class contolMecanim : MonoBehaviour {
    private bool basicA, sideStep,idle;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a")) {
            this.basicA = true;
            this.sideStep = false;
            this.idle = false;
           
        }
        if (Input.GetKeyDown("s")) {
            this.basicA = false;
            this.sideStep = true;
            this.idle = false;

        }
        if (Input.GetKeyDown("i"))
        {
            this.basicA = false;
            this.sideStep = false;
            this.idle = true;

        }
    }
    void FixedUpdate()
    {
        anim.SetBool("basica", this.basicA);
        anim.SetBool("sidestep", this.sideStep);
        anim.SetBool("idle", this.idle);
    }


}
