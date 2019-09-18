using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisioninfo) {
        if(collisioninfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            gameManager.endGame();
        }    
    }
}
