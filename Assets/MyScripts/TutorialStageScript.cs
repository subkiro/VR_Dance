using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialStageScript : MonoBehaviour {
       public Text fooText;
       public int stageNum = 0;
       public GameObject character;

       public GameObject TutorialPanel;
       public GameObject BasicStepsPanel;
       public GameObject DialogPanel;
       public GameObject FrontPanel;
       public GameObject CharacterSelectPanel;

       public GameObject DialogBox;
      private GameObject tmpDialogBox;
    private string[] stageText = {"1) Welcome to Dance lesson tutorial \n Are you ready to start?"
                                , "2) Great \n You just made succesfully Thumb!!"
                                , "3) You can observe around you \n On your right is Menu"
                                , "4)You can Pinch the buttons in Menu \nTry to Press Mute toogle by pinching it"
                                , "5) Play with your hands, it will be easy for you after a while........" 
                                , "6) You can also control the volume of Music\n Just slide the slidebar!!!"
                                , "7) Very Good /n Lets make a WORM UP"
                                , "8) Congradulation! \n Pinch the Next button" };
    // Use this for initialization

 
    void Start () {
        fooText.text = "";
        fullText = stageText[0].ToString();

        InitTypingSound();
        StartCoroutine("ShowText");

        //enable or disabe dialog panels
        this.TutorialDisable();
        this.BasicStepsPanelDisable();
        this.DialogPanelEnable();
        this.FrontPanelDisable();




    }

    public void ShowDialogBox(string msg) {

        if (tmpDialogBox != null)
        {
            Destroy(tmpDialogBox);
            tmpDialogBox = Instantiate(DialogBox);
            tmpDialogBox.GetComponentInChildren<TypeText>().showText(msg);
        }
        else {
            tmpDialogBox = Instantiate(DialogBox);
            tmpDialogBox.GetComponentInChildren<TypeText>().showText(msg);
        }
    }


    public void TutorialEnable() {
        TutorialPanel.SetActive(true);
    }

    public void TutorialDisable()
    {
        TutorialPanel.SetActive(false);
    }

    public void CharacterSelectPanelEnable()
    {
        CharacterSelectPanel.SetActive(true);
    }

    public void CharacterSelectPanelDisable()
    {
        CharacterSelectPanel.SetActive(false);
    }


    public void BasicStepsPanelEnable()
    {
        BasicStepsPanel.SetActive(true);
    }

    public void BasicStepsPanelDisable()
    {
        BasicStepsPanel.SetActive(false);
    }

    public void DialogPanelEnable()
    {
        DialogPanel.SetActive(true);
    }

    public void DialogPanelDisable()
    {
        DialogPanel.SetActive(false);
    }

    public void FrontPanelEnable()
    {
        FrontPanel.SetActive(true);
    }

    public void FrontPanelDisable()
    {
        FrontPanel.SetActive(false);
    }





    public void GoToNextStage() {
        if (DialogPanel.activeSelf==true) { 
            

            if (stageNum < stageText.Length-1)
            {
                stageNum = stageNum + 1;
                
               // ShowDialogBox(fullText); 
                //  currentText = "";
                fullText = stageText[stageNum].ToString();
                StartCoroutine("ShowText");


                
            }

            if (stageNum == stageText.Length - 1)
            {
                Text text = GameObject.Find("ButtonSkipText").GetComponent<Text>();
                text.text = "Next";
                text.color = new Color(255,195,0,80);

            }
            

        }
        

    }


    public AudioClip[] myMusic;    // Use this for initialization
    public AudioSource audio2;
    

    public void PlayDanceMusic() {
        audio2.clip = myMusic[1];
        audio2.volume = 1f;
        audio2.Play();
    }

    public void PlayTutorialMusic()
    {
        audio2.clip = myMusic[0];
        audio2.volume = 1f;
        audio2.Play();
    }


    // ----------------- AUTO TYPE SCRITPS---------------------------------
    private string currentText = "";
    private string fullText;
    public float delay = 0.2f;

    public AudioClip[] typingSound;    // Use this for initialization
    private new AudioSource audio;

    private void InitTypingSound() {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = typingSound[0];
        audio.volume = 0.5f;
    }



    public void PlayTypingSound()
    {
        
        audio.Play();
    }
    public void animatePointToLeft()
    {

        Animator anim = character.GetComponent<Animator>();
        anim.SetTrigger("PointLeft");
    }

    IEnumerator PointToLeftDelayed()
    {
       
        yield return new WaitForSeconds(2);
        animatePointToLeft();
    }



    IEnumerator FlexDelayed()
    {

        yield return new WaitForSeconds(2);
        Animator anim = character.GetComponent<Animator>();
        anim.SetTrigger("Flexing");
    }



    IEnumerator ShowText()
    {
        currentText = "";
        int stage = stageNum;



        
        
        audio.PlayOneShot(typingSound[stageNum+1]);

        if (stageNum == 2 || stageNum == 3 || stageNum == 4)
        {
            StartCoroutine("PointToLeftDelayed");
            
        }

        if (stageNum == 6)
        {
            StartCoroutine("FlexDelayed");

        }


        if (stageNum == 7)
        {
            character.GetComponent<Animator>().SetTrigger("idle");

        }

        foreach (char letter in fullText.ToCharArray())
        {
            if (stage != stageNum) break;

            PlayTypingSound();
            currentText += letter;
            fooText.text = currentText;
            yield return new WaitForSeconds(delay);


            
        }
       

    }
}
