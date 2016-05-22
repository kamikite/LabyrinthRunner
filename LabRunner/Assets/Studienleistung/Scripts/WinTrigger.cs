using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour {
    private GuiManager guiManager;
    private bool waiting;
    IEnumerator WaitingToSwitch()
    {
        while (waiting)
        {
            yield return new WaitForSeconds(5.0f);
            waiting = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PlayerFigure")
        {
            guiManager.winText.text = "YOU WON!";
            StartCoroutine(WaitingToSwitch());
            Debug.Log("You won!");
            Application.LoadLevel(1);
        }

    }
    void OnEnable() {
        guiManager = GameObject.Find("Canvas").GetComponent<GuiManager>();
        waiting = true;
    }
}
