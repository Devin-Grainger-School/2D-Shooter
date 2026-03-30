using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScrpit : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;
    public TagHandle Memory;
    private void Start()
    {
        Cursor.visible = false;
        //memory == GameObject.Find("Player Memory");
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doExitGame();
        }
        //if (GameObject.FindGameObjectWithTag)

    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void doExitGame()
    {
        Application.Quit();
    }

}