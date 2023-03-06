using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() //when the mouse clicks the object it grabs the componenet script off of the game manager and does the function
    {
        GameManager.instance.GetComponent<AsciiLevelLoad>().LevelUp();
    }
}
