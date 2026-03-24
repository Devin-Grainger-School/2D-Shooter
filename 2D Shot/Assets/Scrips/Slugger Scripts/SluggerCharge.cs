using UnityEngine;


public class SluggerCharge : MonoBehaviour
{
    public int Slugger;
    public int Fragment;
    public int Axe;
    public int BOMBS;
    public GameObject[] SluggerPrefabs;
    public GameObject UpSlugger;
    public GameObject DownSlugger;
    public GameObject LeftSlugger;
    public GameObject RightSlugger;
    public GameObject Page;
    public GameObject AxeUp;
    public GameObject AxeDown;
    public GameObject AxeLeft;
    public GameObject AxeRight;
    public GameObject Bomb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Slugger <= 3)
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
            }
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
            {
                // Launch a projectile from the player Left
                Instantiate(LeftSlugger, transform.position, LeftSlugger.transform.rotation);
            }
            if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.L))
            {
                // Launch a projectile from the player Right
                Instantiate(RightSlugger, transform.position, RightSlugger.transform.rotation);
            }
        }
        if (Fragment <= 3)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                // Drops a Page
                Instantiate(Page, transform.position, Page.transform.rotation);
            }
        }

        if (Axe <= 1)
        {
            //Clark
            if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
            {
                // Launch a projectile from the player up
                Instantiate(AxeUp, transform.position, AxeUp.transform.rotation);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
            {
                // Launch a projectile from the layer Down
                Instantiate(AxeDown, transform.position, AxeDown.transform.rotation);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
            {
                // Launch a projectile from the player Left
                Instantiate(AxeLeft, transform.position, AxeLeft.transform.rotation);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
            {
                // Launch a projectile from the player Right
                Instantiate(AxeRight, transform.position, AxeRight.transform.rotation);
            }
        }
        if (BOMBS <= 4) {
            if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
            {
                // Drops a Page
                Instantiate(Bomb, transform.position, Bomb.transform.rotation);
            }
        }
    }
}
