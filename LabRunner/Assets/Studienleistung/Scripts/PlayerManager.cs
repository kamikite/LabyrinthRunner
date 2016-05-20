using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject prefabPlayer;
    private float m_healthPoints;
    private PlayerInputManager inputManager;
    private GameObject Player;
    private float m_maxSpeed;
    private Rigidbody PlayerRigidBody;

    public float HealthPoint
    {
        get {   return m_healthPoints;      }
        set {   m_healthPoints = value;     }
    }

    public void OnEnable() {
        GameObject obj = Instantiate(prefabPlayer, spawnPoint.position, spawnPoint.rotation) as GameObject;
        obj.name = "PlayerFigure";
        Player = GameObject.Find("PlayerFigure");
        PlayerRigidBody = Player.GetComponent<Rigidbody>();
        inputManager = Player.GetComponent<PlayerInputManager>();
        m_healthPoints = 100;
        m_maxSpeed = inputManager.speedBoost;
    }

    private void CheckDeath() {
        if (m_healthPoints <= 0){
            PlayerRigidBody.MovePosition(spawnPoint.position);
            PlayerRigidBody.MoveRotation(spawnPoint.rotation);
        }
    }

    private void UpdateSpeed() {
        if (inputManager.speedBoost < 0){
            inputManager.speedBoost = 0;
        } else {
            inputManager.speedBoost = m_maxSpeed * (m_healthPoints / 100);
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        UpdateSpeed();
	}

    void FixedUpdate () {
   
    }
}
