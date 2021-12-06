using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointNutral : MonoBehaviour
{

    Vector3 pos;
    public bool enabled;
    // Start is called before the first frame update
    void Awake()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled)
            transform.position = pos;
    }
}
