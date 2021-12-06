using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CarControle.startWheelAnim)
        {
            GetComponent<Animator>().enabled = true;
            this.GetComponent<wheel>().enabled = false;
        }
    }
}
