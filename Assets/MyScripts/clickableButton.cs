using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class clickableButton : MonoBehaviour
{

    // Use this for initialization
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        Physics.IgnoreLayerCollision(0, 5, true);
    }


     void OnTriggerEnter(Collider collision)
    {
        anim.SetBool("Normal", false);
        anim.SetBool("Highlighted", true);
       // anim.SetBool("Pressed", true);
      
        GetComponent<AudioSource>().Play();
        ExecuteEvents.Execute<IPointerClickHandler>(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
    }

    void OnTriggerExit(Collider collision)
    {
        anim.SetBool("Highlighted", false);
        anim.SetBool("Normal", true);
       // anim.SetBool("Pressed", false);
    }

   


    


    // Update is called once per frame
}
