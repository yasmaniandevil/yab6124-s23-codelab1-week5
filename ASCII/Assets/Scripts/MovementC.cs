using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementC : MonoBehaviour
{
    public float speed = 2;

    private float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;
        transform.position = newPos;
        
        
    }
}
