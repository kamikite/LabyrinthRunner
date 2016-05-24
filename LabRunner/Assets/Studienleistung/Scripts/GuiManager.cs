using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiManager : MonoBehaviour {

    public Text healthPointsText;
    public Text infoText;
    public Text winText;

    private SceneManager sceneManager;

    void OnEnable()
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
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
