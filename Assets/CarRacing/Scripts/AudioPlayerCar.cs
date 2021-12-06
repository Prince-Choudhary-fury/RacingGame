using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerCar : MonoBehaviour
{

    public GameObject[] engineAudio;


    public Rigidbody carRigidbody;

    private void Update()
    {
        if (carRigidbody.velocity.z < 0)
        {
            PlayAudio(3);
        }
        
        if (carRigidbody.velocity.z > 1)
        {
            PlayAudio(0);
        }
        
        if (carRigidbody.velocity.z >= 0 && carRigidbody.velocity.z <= 1)
        {
            PlayAudio(1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            engineAudio[5].GetComponent<AudioSource>().Play();
        }
    }

    private void PlayAudio(int audioIndex)
    {
        for (int i = 0; i < 4; i++)
        {
            if(audioIndex != i)
            {
                engineAudio[i].SetActive(false);
            }
            else
            {
                engineAudio[audioIndex].SetActive(true);
            }
        }
    }
}
