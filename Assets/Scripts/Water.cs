using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    private Powerup thePowerup;

    void Start () {
    }

    void Update () {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Seed")
        {
            thePowerup.ActivateWater();
        }
    }
}
