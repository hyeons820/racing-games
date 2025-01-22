using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasManager : MonoBehaviour
{
    private float speed = 40f;

    private void Update()
    {
        gameObject.transform.Translate(0, -1 * speed * Time.deltaTime, 0);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Car"))
        {
            Debug.Log("Gas");
            Car.hp += 30;
            Destroy(gameObject);
        }
    }
}
