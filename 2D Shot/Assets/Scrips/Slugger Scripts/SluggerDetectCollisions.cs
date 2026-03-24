using UnityEngine;

public class SluggerDetectCollisions : MonoBehaviour
{
    public string TagtoDestroy;
    //Destory Monsters on Collision
    void OnTriggerEnter(Collider other)
    {
        // Check if the object the projectile collided with has the "Enemy" tag
        if (other.CompareTag(TagtoDestroy))
        {
            Destroy(other.gameObject);
            
        }
        if (other.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }

    }
}
