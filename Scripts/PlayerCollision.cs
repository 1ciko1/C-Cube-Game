using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    // 3. kodlama kısmı

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")

        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        
        }


    }

}
  
