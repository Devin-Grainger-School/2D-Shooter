using UnityEngine;


public class SluggerCharge : MonoBehaviour
{
    public int Slugger;
    public int Fragment;
    
    public GameObject[] SluggerPrefabs;
    public GameObject UpSlugger;
    public GameObject DownSlugger;
    public GameObject LeftSlugger;
    public GameObject RightSlugger;
    public GameObject Page;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Slugger <= 2)
        {

            //Memory
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.I))
            {
                // Launch a projectile from the player up
                Instantiate(UpSlugger, transform.position, UpSlugger.transform.rotation);
                Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.K))
            {
                // Launch a projectile from the player Down
                Instantiate(DownSlugger, transform.position, DownSlugger.transform.rotation);
                Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
            {
                // Launch a projectile from the player Left
                Instantiate(LeftSlugger, transform.position, LeftSlugger.transform.rotation);
                Slugger++;
            }
            if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.L))
            {
                // Launch a projectile from the player Right
                Instantiate(RightSlugger, transform.position, RightSlugger.transform.rotation);
                Slugger++;
            }
        }
        if (Fragment <= 3)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                // Drops a Page
                Instantiate(Page, transform.position, Page.transform.rotation);
                Fragment++;
            }
        }
    }
}
