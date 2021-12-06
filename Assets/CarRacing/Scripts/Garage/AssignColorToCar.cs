using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignColorToCar : MonoBehaviour
{

    public MeshRenderer Mesh;

    // Start is called before the first frame update
    void Awake()
    {
        Mesh.material.color = garageManager.currentColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
