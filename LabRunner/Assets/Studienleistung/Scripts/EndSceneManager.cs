using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneManager : MonoBehaviour {

    public Button restartButton;
    public Text infoText;
    public 
	// Use this for initialization
	void OnEnable () {
        restartButton.onClick.AddListener(() =>
        {
            Destroy(GameObject.Find("Canvas"));
            Application.LoadLevel(0);
        });
	}

    public void Init(string msg)
    {
        infoText.text = msg;
    }
}
