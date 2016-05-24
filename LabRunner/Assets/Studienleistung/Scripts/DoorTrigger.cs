using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

    public GameObject doorObj;
    private Door doorScript;
    private bool action;
    private GuiManager guiManager;
    private AudioSource triggerAudio;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PlayerFigure")
        {

            triggerAudio.Play();
            action = true;
            guiManager.infoText.text = "Press E to open! Press R to close!";
        }
        else { 
            
        }
    }
    void OnTriggerExit()
    {
        guiManager.infoText.text = "";
        action = false;
    }

    void OnEnable(){
        doorScript = doorObj.GetComponent<Door>();
        action = false;
        guiManager = GameObject.Find("Canvas").GetComponent<GuiManager>();
        triggerAudio = GameObject.Find("Doors").GetComponent<AudioSource>();
    }
	
	void Update () {
        if (Input.GetKey(KeyCode.E) && action){
            doorScript.IsOpen = true;
        }

        if (Input.GetKey(KeyCode.R) && action)
        {
            doorScript.IsOpen = false;
        }
       
	}
}
