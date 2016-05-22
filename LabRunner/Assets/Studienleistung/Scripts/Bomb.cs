using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
    private PlayerManager Player;
    private float bombDMG;
    
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "PlayerFigure")
        {
            Player = col.gameObject.GetComponent<PlayerManager>();
            Player.HealthPoint -= bombDMG;
            Debug.Log("Boooom! Aua! + " + Player.HealthPoint); 
            Destroy(this.gameObject); 
        }
    }

    void OnEnable()
    {
        bombDMG = 10;
    }

}
