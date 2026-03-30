using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class AxeThrow : MonoBehaviour
{
    public int Axe;
    public int BOMBS;
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
        if (Axe <= 1)
        {
            //Clark
            if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
            {
                // Launch a projectile from the player up
                Instantiate(AxeUp, transform.position, AxeUp.transform.rotation);
                Axe++;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
            {
                // Launch a projectile from the layer Down
                Instantiate(AxeDown, transform.position, AxeDown.transform.rotation);
                Axe++;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
            {
                // Launch a projectile from the player Left
                Instantiate(AxeLeft, transform.position, AxeLeft.transform.rotation);
                Axe++;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
            {
                // Launch a projectile from the player Right
                Instantiate(AxeRight, transform.position, AxeRight.transform.rotation);
                Axe++;
            }
        }
        if (BOMBS <= 4)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
            {
                // Drops a Page
                Instantiate(Bomb, transform.position, Bomb.transform.rotation);
                BOMBS++;
            }
        }
    }
}
