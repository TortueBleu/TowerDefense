using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoStartScene()
    {
        SceneManager.LoadScene("start");
        
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void GotoExitScene()
    {
        Application.Quit();
        
    }

}