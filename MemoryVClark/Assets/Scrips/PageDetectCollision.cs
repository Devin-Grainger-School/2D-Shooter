using UnityEngine;

public class PageDetectCollision : MonoBehaviour
{
    public string TagtoDestory;
    // Destory's Monster and Page
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagtoDestory))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
