using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //private int laps = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("chocaste wn!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // laps++;
        // Debug.Log("vas " + laps.ToString() + " vuelta/s");
        if (other.tag == "Package")
        {
            Debug.Log("package picked up");
        }
    }
}
