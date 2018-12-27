using UnityEngine;

public class Collison : MonoBehaviour
{
    public PlayerMovement playerMovement;
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// <param name="info">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag=="Obstacle"){
           FindObjectOfType<GameManager>().GameOver();
        }
    } 
}
