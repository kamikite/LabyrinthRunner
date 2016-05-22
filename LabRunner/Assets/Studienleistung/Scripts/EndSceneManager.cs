using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneManager : MonoBehaviour {

    public Button restartButton;
	// Use this for initialization
	void OnEnable () {
        restartButton.onClick.AddListener(() =>
        {
            Application.LoadLevel(0);
        });
	}
}
