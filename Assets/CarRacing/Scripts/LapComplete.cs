using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliDisplay;

    public GameObject lapTimeBox;

    public GameObject lapCounter;

    public int lapDone = 0;
    public static int currentScene;

    public float rawTime;

    public GameObject RaceFinishCam;
    public GameObject currentCam;

    
    public static bool isFinish = false;

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lapDone += 1;
            rawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.rawTime <= rawTime)
            {
                if (LapTimeManager.secondCount <= 9)
                {
                    secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
                }
                else
                {
                    secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
                }
                if (LapTimeManager.minuteCount <= 9)
                {
                    minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
                }
                else
                {
                    minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
                }
                milliDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliCount;
            }
            PlayerPrefs.SetInt("MinSave", LapTimeManager.minuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.secondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.milliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

            LapTimeManager.minuteCount = 0;
            LapTimeManager.secondCount = 0;
            LapTimeManager.milliCount = 0;
            LapTimeManager.rawTime = 0;

            lapCounter.GetComponent<Text>().text = "" + lapDone;

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                Gamefinish(1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                Gamefinish(2);
            }
            halfLapTrig.SetActive(true);
            lapCompleteTrig.SetActive(false);
        }
    }

    public void Gamefinish(int maxLaps)
    {
        if(lapDone == maxLaps)
        {
            
            currentScene = SceneManager.GetActiveScene().buildIndex;
            RaceFinishCam.SetActive(true);
            currentCam.SetActive(false);
            isFinish = true;
            CarController.m_Topspeed = 0;
            Debug.Log("collided");
        }
    }

}
