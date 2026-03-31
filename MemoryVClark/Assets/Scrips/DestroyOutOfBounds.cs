using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 18;
    private float lowerBound = -18;
    //public SluggerCharge SluggerCharge;
    public SluggerCharge AXE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
           // Destroy(gameObject);
            //SluggerCharge.Slugger--;
        }
        else if (transform.position.y < lowerBound)
        {
            //Destroy(gameObject);
        }
        if (transform.position.x > topBound)
        {
            //Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            //Destroy(gameObject);
        }
    }
}
