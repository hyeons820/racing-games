using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GasSpawner : MonoBehaviour
{
    private int randomX;
    private int randomY;
    private float timer = 2;
    public GameObject gasPrefab;
 
    private Vector2 randomPos;
    

    private void Update()
    {
        randomX = Random.Range(-9, 9);
        randomY = Random.Range(41, 60);
        randomPos = new Vector2(randomX, randomY);
        
        timer -= Time.deltaTime;
        
        if (timer <= 0.0f)
        {
            Debug.Log(randomPos);
            Instantiate(gasPrefab, randomPos, Quaternion.identity);
            timer = 3.5f;
        }
    }
}
