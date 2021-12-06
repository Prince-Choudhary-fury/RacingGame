using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject trackSelecterMenu;
    private int sceneIndex;

    private void Start()
    {
        sceneIndex = LapComplete.currentScene;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void TracksButtom()
    {
        mainMenu.SetActive(false);
        trackSelecterMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void crossButton()
    {
        mainMenu.SetActive(true);
        trackSelecterMenu.SetActive(false);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void TrackOne()
    {
        SceneManager.LoadScene(1);
    }
    
    public void TrackTwo()
    {
        SceneManager.LoadScene(2);
    }
    
    public void TrackThree()
    {
        SceneManager.LoadScene(3);
    }
    
    public void TrackFour()
    {
        SceneManager.LoadScene(4);
    }

    public void garage()
    {
        SceneManager.LoadScene(5);
    }

}
