using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static float PlayerStats; // Example stat variable

    private float timer;
    private float maxTime = 10f; // Example: 60 seconds
    private string gameState = "Title"; // Example game state variable

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            // Initialize PlayerStats if necessary
            PlayerStats = 0f; // Or load saved stats here
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (gameState == "Game")
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                LoadStartScreen();
            }
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        gameState = "Game";
        timer = 0; // Reset timer
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene("Titel");
        gameState = "Title";
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
