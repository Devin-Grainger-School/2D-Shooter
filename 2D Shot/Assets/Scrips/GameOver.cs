using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float playerDead;
    public TextMeshProUGUI gameOverText;
    public GameObject StartButton;
    public GameObject MimiWins;
    public GameObject ClarkWins;

    bool MemoryExists = (GameObject.FindGameObjectsWithTag("Memory").Length > 0);
    public GameObject livecharac;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Kills player after Game Over
        if (livecharac)
        {
            Debug.Log ("Hello");
        }
        else
        {
            gameOverText.gameObject.SetActive(true);
            StartButton.gameObject.SetActive(true);
            MimiWins.gameObject.SetActive(true);
            ClarkWins.gameObject.SetActive(true);
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
       //estroy(gameObject);
    }
}
