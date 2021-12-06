using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public GameObject countDown;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject LapTimer;
    public GameObject CarControls;

    void Start()
    {
        CarController.m_Topspeed = 200;
        StartCoroutine(CountStart());
        Cursor.lockState = CursorLockMode.Locked;
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "Go!";
        goAudio.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown.SetActive(false);
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

}
