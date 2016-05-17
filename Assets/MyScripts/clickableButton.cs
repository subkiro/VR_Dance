using UnityEngine;
using System.Collections;

public class clickableButton : MonoBehaviour
{

    // Use this for initialization
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void OnTriggerEnter(Collider collision)
    {
        anim.SetBool("Normal", false);
        anim.SetBool("Highlighted", true);
        GetComponent<AudioSource>().Play();

    }

    void OnTriggerExit(Collider collision)
    {
        anim.SetBool("Highlighted", false);
        anim.SetBool("Normal", true);

    }


    // Update is called once per frame
}
