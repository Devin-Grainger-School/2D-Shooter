using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float playerDead;

    public int isdead = 0;
    
    public TextMeshProUGUI gameOverText;
    public GameObject StartButton;
    public GameObject MiniWins;
    public GameObject ClarkWins;

    public void SelfDestruct()
    {
        isdead = 1;
        
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Kills player after Game Over
        if (isdead >= 1)
        {
            gameOverText.gameObject.SetActive(true);
            StartButton.gameObject.SetActive(true);
            ClarkWins.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
    }
}
