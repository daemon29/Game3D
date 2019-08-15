using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float minSwipeDistY;

    public float minSwipeDistX, speed = 10;

    private Vector2 startPos;

    public GameObject character;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            character.transform.position += new Vector3(-Time.deltaTime * 6f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            character.transform.position += new Vector3(Time.deltaTime * 6f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            character.transform.position += new Vector3(0, 0, Time.deltaTime * 6f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            character.transform.position += new Vector3(0, 0, -Time.deltaTime * 6f);
        }
    }

}
