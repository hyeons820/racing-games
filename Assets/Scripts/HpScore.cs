using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HpScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    void Update()
    {
        text.text = $"Hp : {Car.score.ToString()}";
    }
}
