using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatoer : MonoBehaviour
{

    Transform platform;
    public float rotationSpeed = 1f;

    public static int currentPloyerChar;

    private Vector2 lastTapPos;
    private bool loadChar = false;

    private void Awake()
    {
        platform = GetComponent<Transform>();
    }

    void Update()
    {
        charRotator();
    }

    public void charRotator()
    {
        //checks for left mouse button input
        if (Input.GetMouseButton(0))
        {
            //drag tap location of left mouse button
            Vector2 curTapPos = Input.mousePosition;
            if (lastTapPos == Vector2.zero)
            {
                lastTapPos = curTapPos;
            }
            //difference between last tap location till the end tap drag 
            float delta = lastTapPos.x - curTapPos.x;
            lastTapPos = curTapPos;
            platform.Rotate(Vector3.up * delta * rotationSpeed);
        }

        if (Input.GetMouseButtonUp(0))
        {
            lastTapPos = Vector2.zero;
        }

    }
}
