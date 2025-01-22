using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{ 
    public static float hp = 100;
    private float decHp = 10f;
    public static int score;
    public GameObject gameOver;

    void Start()
    {
        hp = 100;
    }

    void Update()
    {
        hp -= decHp * Time.deltaTime;
        score = (int)hp;
        
        if (hp <= 0)
            GameOver();
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
    }
}
