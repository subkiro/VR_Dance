using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIMove : MonoBehaviour {
    public NavMeshAgent agent;
    public Transform target;
    // Use this for initialization
    void Start () {
        agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        agent.updatePosition = true;
    }
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            GetComponent<Animator>().SetBool("Walk", true);
            transform.LookAt(target);
        }
        else {
            GetComponent<Animator>().SetBool("Walk", false);
        }




        }
    }
