using UnityEngine;
using System.Collections;
using Leap;
public class fistTest : MonoBehaviour {
    private Controller controller;
    private FingerList extendFingers;
    public  bool fistActive;
    public float grabStrength;


    // Use this for initialization
    void Start () {


        fistActive = false;
        grabStrength = 0;
        controller = new Controller();

    }
	
	// Update is called once per frame
	void Update () {

        fistControl();
     

        }






    //--------------------------------------------------------------------------------------
    public void fistControl() {

        Frame frame = controller.Frame();
        Hand LefttHand = frame.Hands.Leftmost;



        if (LefttHand.IsLeft)
        {

            grabStrength = LefttHand.GrabStrength;
           // print("found right hand");
            extendFingers = LefttHand.Fingers.Extended();

            if (extendFingers.Count == 0)
            {

                fistActive = true;
            }
            else {
                fistActive = false;
            }

        }



        }
}
