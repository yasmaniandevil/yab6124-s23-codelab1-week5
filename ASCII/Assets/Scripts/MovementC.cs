using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementC : MonoBehaviour
{
    public float speed = 2;

    private float x; //float variable for the x axis
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position; //transform the position of obj to new vector2
        newPos.x += speed * Time.deltaTime; //new position x times the frame rates
        transform.position = newPos; //then transform the position and set to new position
        
        
    }
}
