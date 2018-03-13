using UnityEngine.UI; //include UI namespace before class declaration

using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class CharacterMechanics : MonoBehaviour {

    public Toggle toggle; //drag from inspector
    public GameObject Avatar;
    
    private bool basicA,sideStep_control, sideStep, idle;
    private Animator animator;
    public GameObject target;


    public Transform AI_target;
    private NavMeshAgent agent;
    

    private bool basicState = true;
   

    //This is for controling wheather to make side steps or Turn




    // Use this for initialization




    void Start()
    {
       
        animator = Avatar.GetComponent<Animator>();
        agent = Avatar.GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = true;
        agent.updatePosition = true;
    }

    public void initNavMesh() {
        animator = Avatar.GetComponent<Animator>();
        agent = Avatar.GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
        //agent.updateRotation = true;
        //agent.updatePosition = true;
    }


    public void TurnOff_AI_Move() {
        agent.updateRotation = false;
        agent.updatePosition = false;
    }
    public void TurnOn_AI_Move()
    {
        agent.updateRotation = true;
        agent.updatePosition = true;
    }

    void Update() {

        if (basicState) {

           

        }
        else {

            //AI move  -------------------------------------------
           
            agent.SetDestination(AI_target.position);
            
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                Avatar.GetComponent<Animator>().SetBool("Walk", true);
                transform.LookAt(AI_target);
            }
            else {
                Avatar.GetComponent<Animator>().SetBool("Walk", false);
            }
                //----------------------------------------------------
          
            this.animator.SetFloat("SideStepsFloat", Avatar.GetComponent<IK_Scr>().sideStepsFloat);
        this.animator.SetFloat("TurnFloat", Avatar.GetComponent<IK_Scr>().TrunFloat);
        }

    }
   

    public void SetAnimator_For_BasicSteps()
    {
        basicState = true;
        Avatar.transform.position = new Vector3(0, 0, 3f);

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("BasicA"))
        {
            animator.SetTrigger("idle");
        }
        agent.ResetPath();


    }
    public void SetAnimator_For_Interaction()
    {

        basicState = false;
        //Avatar.transform.position = new Vector3(0, 0, 0.8f);

        animator.Play("Idle");
    }
    public void SetAnimator_For_Dance()
    {

    }




    public void eventOnClick_BasicA()
    {
        
            animator.SetTrigger("BasicATutorial");
       
    }

    public void eventOnClick_Idle()
    {
        
        animator.SetTrigger("idle");


    }

    public void eventOnClick_SideSteps()
    {


        animator.SetTrigger("SideStepTutorial");


    }

    public void eventOnClick_Turn()
    {
        animator.SetTrigger("TurnTutorial");

    }

    public void eventOnClick_Flexing()
    {
        animator.SetTrigger("Flexing");

    }


    public void eventOnClick_Waving()
    {
        animator.SetTrigger("Waving");


    }

    public void eventOnClick_PointLeft()
    {
        animator.SetTrigger("PointLeft");

    }


    

    // Update is called once per frame
    
   


}