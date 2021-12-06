using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapCompleteTrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lapCompleteTrig.SetActive(true);
            halfLapCompleteTrig.SetActive(false);
        }
    }

}
