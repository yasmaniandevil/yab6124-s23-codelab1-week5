using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 StartPos;
    public float speed = 2;
    //private Vector2 newPos;
    public int amp = 1;
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(
            //Random.Range(-2f, 5f),
            //Random.Range(-2f, 5f));

            transform.position = StartPos + new Vector2(Mathf.Sin(Time.time * speed * amp), Mathf.Cos(Time.time * speed * amp) );
            
            //newPos = transform.position;
            //newPos.x = Mathf.Sin(Time.time) * speed * Time.deltaTime;
            //transform.position = newPos;

            
            
    }
    
}
