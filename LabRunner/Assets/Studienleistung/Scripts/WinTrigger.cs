using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour {
    private GuiManager guiManager;
    private bool waiting;
    private EndSceneManager end;
    IEnumerator WaitingToSwitch()
    {
        while (waiting)
        {
            yield return new WaitForSeconds(5.0f);
            waiting = false;
        }
        SceneManager.LoadScene(1);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PlayerFigure")
        {
            guiManager.winText.text = "YOU WON!";
            guiManager.healthPointsText.text = "";
            StartCoroutine(WaitingToSwitch());
            Debug.Log("You won!");
         
            
        }

    }
    void OnEnable() {
        guiManager = GameObject.Find("Canvas").GetComponent<GuiManager>();
        waiting = true;
    }
}
