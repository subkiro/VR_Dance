using UnityEngine;
using System.Collections;


public class MenuManager : MonoBehaviour {

    
    public Menu  CurrentMenu;
    GameObject _scripts;

    public void Start() {
        _scripts= GameObject.Find("_Scripts_");

         ShowMenu(CurrentMenu);

    }

    void FixedUpdate()
    {
       
        float grabstrength = _scripts.GetComponent<fistTest>().grabStrength;
        if (grabstrength==0 && CurrentMenu != null && _scripts.GetComponent<RayFromPalm>().iSeeMyPalm)
        {
            
            CurrentMenu.IsOpen = true;
        }
        else 
        {
            CurrentMenu.IsOpen = false;
            
        }

    }



    public void ShowMenu(Menu menu) {
                      
                if (CurrentMenu != null)
                CurrentMenu.IsOpen = false;

                CurrentMenu = menu;
                CurrentMenu.IsOpen = true;
       
    }

}
