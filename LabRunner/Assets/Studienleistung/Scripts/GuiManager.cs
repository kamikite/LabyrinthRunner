using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiManager : MonoBehaviour {

    public Text healthPointsText;
    public Text infoText;
    public Text winText;

    private StartSceneManager sceneManager;

    void OnEnable()
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<StartSceneManager>();
        DontDestroyOnLoad(this);
        disableWin();
    }
    void disableWin()
    {
        winText.text = ""; // "You win!"
    }

	// Update is called once per frame
	void FixedUpdate () {
	    healthPointsText.text = ("HealthPoints: " + sceneManager.playerManager.HealthPoint);
	}
}
