using UnityEngine;
using Leap;

public class menuFollow : MonoBehaviour {

    public float x,y,z;
    private Controller controller; //need for checking the left hand existance
    // Use this for initialization

    void Start() {
        controller = new Controller();
        if (float.IsNaN(x) || float.IsNaN(y) || float.IsNaN(z)) { 
        this.x = 0;
        this.y = 0;
        this.z = 0;
        


        }

     
    }
	
	// Update is called once per frame
	void FixedUpdate () {

// code for cheking the left hand
        Frame frame = controller.Frame();
        HandList hands = frame.Hands;
        Hand LefttHand = hands.Leftmost;
        //----------------------------------------------------





        if (LefttHand.IsLeft)
        {
            if (GameObject.Find("palm") != null)
            {
                this.transform.position = GameObject.Find("palm").transform.position + new Vector3(x, y, z);
            }

        }


    }

}
