using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public bool m_isOpen;
    public bool IsOpen
    {
        get { return m_isOpen; }
        set { m_isOpen = value; }
    }

	// Use this for initialization
	void Start () {
        m_isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (m_isOpen) {
            if (transform.position.y >= 0) {
                transform.Translate(Vector3.down * Time.deltaTime);
            }
        } else {
            if (transform.position.y <= 3) {
                transform.Translate(Vector3.up * Time.deltaTime);
            }
        }
	}
}
