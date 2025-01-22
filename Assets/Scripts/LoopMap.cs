using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMap : MonoBehaviour
{
    private float speed = 70f;
    public float startPos;
    public float endPos;

    void Start()
    {
       
    }
    
    void Update()
    {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        
        if (transform.position.y <= endPos)
        {
            ScollEnd();
        }
    }

    private void ScollEnd()
    {
        transform.Translate(0, -1 * (endPos - startPos), 0);
    }
}
