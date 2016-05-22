using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    private float m_maxSpeed;
    private float m_healthPoints;

    private GameObject Player;
    private PlayerInputManager InputManager;
    private PlayerManager Manager;
    private Transform spawnPoint;
    private SceneManager sceneManager;

 
    public float HealthPoint
    {
        get {   return m_healthPoints;      }
        set {   m_healthPoints = value;     }
    }

    public void Init(GameObject playerObj, Transform spawnObj,  PlayerManager managerObj, PlayerInputManager inputObj, SceneManager scManager) {

        m_healthPoints = 100;

        this.Player = playerObj;
        this.InputManager = inputObj;
        this.Manager = managerObj;
        this.spawnPoint = spawnObj;
        this.sceneManager = scManager;

        m_maxSpeed = InputManager.speedBoost;
        
        InputManager.Init();
  
    }

    private void UpdateSpeed() {

        if (InputManager.speedBoost < 0){
            InputManager.speedBoost = 0;
        } else {
            InputManager.speedBoost = m_maxSpeed * (m_healthPoints / 100);
        }
    }

    void FixedUpdate()
    {
        UpdateSpeed();
    }
}
