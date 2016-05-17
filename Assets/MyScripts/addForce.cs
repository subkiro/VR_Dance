using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {
    
    public float torque;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    {
        float turn = -1;
        rb.AddTorque(transform.forward * torque * turn);
    }

}
