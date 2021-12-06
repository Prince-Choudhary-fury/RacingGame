using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int camMode;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("ViewPort"))
        {
            if (camMode == 2)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
            StartCoroutine(CamModeChanger());
        }
    }

    IEnumerator CamModeChanger()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        else if (camMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        else if (camMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }

}
