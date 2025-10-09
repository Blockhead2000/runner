using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Scene Name")]
    public string gameSceneName = "GameScene";

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(gameSceneName);

    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

