using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Name of the scene to load first goes here.")]
    private string gameSceneName;

    public void LoadGameScene()
    {
        //Loads the scene when Play is selected.
        SceneManager.LoadScene(gameSceneName);
    }

    public void ExitGame()
    {
        //Exits the game when Exit is selected.
        Application.Quit();
    }
}
