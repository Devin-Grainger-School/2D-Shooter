using UnityEngine;

public class Walls2 : MonoBehaviour
{
    public AxeThrow AxeThrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Axe"))
            {
                Destroy(other.gameObject);
                AxeThrow.Axe--;
            }
        }
    }
}
