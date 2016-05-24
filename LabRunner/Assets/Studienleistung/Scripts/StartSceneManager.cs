using UnityEngine;
using System.Collections;

public class StartSceneManager : MonoBehaviour {
    public Transform spawnPoint;
    public GameObject prefabPlayer;
    public Transform [] spawnBomb ;
    public GameObject prefabBomb;

    private GameObject Player;
    private PlayerInputManager InputManager;
    private PlayerManager Manager;
    private Rigidbody PlayerRigidBody;
    private GuiManager guiScript;

    public PlayerManager playerManager
    {
        get { return Manager; }
        set { Manager = value; }
    }
    public void OnEnable()
    {
        GameObject obj = Instantiate(prefabPlayer, spawnPoint.position, spawnPoint.rotation) as GameObject;
        obj.name = "PlayerFigure";
        Manager = obj.GetComponent<PlayerManager>();
        InputManager = obj.GetComponent<PlayerInputManager>();
        PlayerRigidBody = obj.GetComponent<Rigidbody>();

        Manager.Init(obj, spawnPoint, Manager, InputManager, this);

        for (int i = 0; i < spawnBomb.Length; i++)
        {
            GameObject bomb = Instantiate(prefabBomb, spawnBomb[i].position, spawnBomb[i].rotation) as GameObject;
            bomb.name = "Bomb" + i;
        }
    }

    private void CheckDeath()
    {
        if (Manager.HealthPoint <= 0)
        {
            PlayerRigidBody.MovePosition(spawnPoint.position);
            PlayerRigidBody.MoveRotation(spawnPoint.rotation);
            Manager.HealthPoint = 100;
        }
    }

	void FixedUpdate () {
        CheckDeath();
	}
}
