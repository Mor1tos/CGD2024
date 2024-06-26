using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private float timer;
    private float maxTime = 10f; // Example: 60 seconds
    private string gameState = "Title"; // Example game state variable

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
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

    // New function to reset player stats and load the game scene
    public void NewGame()
    {
        if (Playerstats.Instance != null)
        {
            Playerstats.Instance.ResetStats(); // Reset PlayerStats
        }
        LoadGame(); // Load the game scene
    }

    // Assuming you have a button with the "New Game" action in your scene
    public void SetUpButtons(Button newGameButton, Button exitButton)
    {
        newGameButton.onClick.AddListener(NewGame);
        exitButton.onClick.AddListener(ExitGame);
    }
}
