using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class CarControle : MonoBehaviour
{

    public CarAIControl[] AICar;
    public CarUserControl Car;

    private int finishMenuLoadWaitTime = 5;

    public static bool startWheelAnim;

    private void Update()
    {
        if (LapComplete.isFinish)
        {
            StartCoroutine(levelCompleteMenu());
            LapComplete.isFinish = false;
        }
    }

    IEnumerator levelCompleteMenu()
    {
        yield return new WaitForSeconds(finishMenuLoadWaitTime);
        SceneManager.LoadScene(3);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < AICar.Length; i++)
        {
            AICar[i].enabled = true;
        }
        Car.enabled = true;
        startWheelAnim = true;
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

}
