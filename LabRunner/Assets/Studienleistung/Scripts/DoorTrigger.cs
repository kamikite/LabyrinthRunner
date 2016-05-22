using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

    public GameObject doorObj;
    private Door doorScript;
    private bool action;
    private GuiManager guiManager;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PlayerFigure")
        {
            action = true;
            guiManager.infoText.text = "Press E to activate!";
        }
        else { 
            action = false;
        }
    }
    void OnTriggerExit()
    {
        guiManager.infoText.text = ""; 
    }

    void OnEnable(){
        doorScript = doorObj.GetComponent<Door>();
        action = false;
        guiManager = GameObject.Find("Canvas").GetComponent<GuiManager>();
    }
	
	void Update () {
        if (Input.GetKey(KeyCode.E) && action){
                doorScript.IsOpen = true;
        }
       
	}
}
