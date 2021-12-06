using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{

    public int minCount;
    public int secCount;
    public float milliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    void Start()
    {
        minCount = PlayerPrefs.GetInt("MinSave");
        secCount = PlayerPrefs.GetInt("SecSave");
        milliCount = PlayerPrefs.GetFloat("MilliSave");

        MinDisplay.GetComponent<Text>().text = "" + minCount + ":";
        SecDisplay.GetComponent<Text>().text = "" + secCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + milliCount;

    }
}
