using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 StartPos; //variable of start pos
    public float speed = 2; //how fast the obj goes
    //private Vector2 newPos;
    public int amp = 1; //how the obj moves up and down
    void Start()
    {
        StartPos = transform.position; //set the start position of obj
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(
            //Random.Range(-2f, 5f),
            //Random.Range(-2f, 5f));

            //transform the start position and create a new vector 2 with mathf sin that moves it smoothly along whatever axis
            //cos and sin together moves it in circles
            //multiple it by the time speed and amp
            transform.position = StartPos + new Vector2(Mathf.Sin(Time.time * speed * amp), Mathf.Cos(Time.time * speed * amp) );
            
            //newPos = transform.position;
            //newPos.x = Mathf.Sin(Time.time) * speed * Time.deltaTime;
            //transform.position = newPos;

            
            
    }
    
}
