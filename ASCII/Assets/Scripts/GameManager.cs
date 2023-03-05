using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; //holds the singleton

    private int currentLevel = 0;

    private void Awake()
    {
        if (instance == null) //instance hasnt been set yet
        {
            DontDestroyOnLoad(gameObject); //dont destory the script
            instance = this; //the instance will be this one
        }
        else //if instance is already set to an object
        {
            Destroy(gameObject); //then destroy it so there is only ever one
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
