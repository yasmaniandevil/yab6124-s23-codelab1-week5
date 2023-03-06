using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col) //collider for when the obj player hits the wall
    {
        Debug.Log("Hit Wall: " + col.gameObject.name.Contains("Player"));

        if (col.gameObject.name.Contains("Player"))//if the player collides with the wall
        {
            GameManager.instance.GetComponent<AsciiLevelLoad>().ResetComputer();//then go to game manager-> get componenet of script attached to it, and grab the function within that script
            Debug.Log("Hit Wall");
        }
    }
}

