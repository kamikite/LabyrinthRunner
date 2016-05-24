using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour {

    public Button restartButton;
    public Text infoText;
	// Use this for initialization
	void OnEnable () {
        restartButton.onClick.AddListener(() =>
        {
            Destroy(GameObject.Find("Canvas"));
            //Application.LoadLevel(0);
            SceneManager.LoadScene(0);
        });
	}

    public void Init(string msg)
    {
        infoText.text = msg;
    }
}
