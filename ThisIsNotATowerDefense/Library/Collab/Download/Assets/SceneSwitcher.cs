using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void GamePause()
    {
        Time.timeScale = 1;
    }

    public void GotoStartScene()
    {
        SceneManager.LoadScene("start");
        
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("lvlchoose");
        Time.timeScale = 1;
    }

    public void GotoExitScene()
    {
        Application.Quit();
        
    }

    public void GotoLevel1()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void GotoLevel2()
    {
        SceneManager.LoadScene("lvl2");
        Time.timeScale = 1;
    }

    public void GotoLevel3()
    {
        SceneManager.LoadScene("lvl3");
        Time.timeScale = 1;
    }

    public void GotoLevel4()
    {
        SceneManager.LoadScene("lvl4");
        Time.timeScale = 1;
    }
}