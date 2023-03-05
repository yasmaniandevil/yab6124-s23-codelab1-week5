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

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit Wall: " + col.gameObject.name.Contains("Player"));

        if (col.gameObject.name.Contains("Player"))
        {
            GameManager.instance.GetComponent<AsciiLevelLoad>().ResetComputer();
            Debug.Log("Hit Wall");
        }
    }
}

