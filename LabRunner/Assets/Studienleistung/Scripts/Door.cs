using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public bool m_isOpen;
    private AudioSource doorSource;
    private bool once;

    public bool IsOpen
    {
        get { return m_isOpen; }
        set { m_isOpen = value; }
    }

	// Use this for initialization
	void Start () {
        m_isOpen = false;
        doorSource = GetComponent<AudioSource>();
        once = true;

	}
	
	// Update is called once per frame
	void Update () {
        if (m_isOpen) {
            if (once)
            {
                doorSource.Play();
                doorSource.volume = 1;
                once = false;
            }
            
            if (transform.position.y >= 1.5) {
                transform.Translate(Vector3.down * Time.deltaTime);
                if (transform.position.y <= 1.5)
                {
                    doorSource.Stop();
                }
                
            }
        }
        else if (!m_isOpen)
        {
            once = true;
            if (transform.position.y < 3)
            {
                transform.Translate(Vector3.up * Time.deltaTime);
            }
        }
	}
}
