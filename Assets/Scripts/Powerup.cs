using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Sprite Level1;
    public Sprite Level2;
    public Sprite Level3;
    public Sprite Level4;

    private bool waterActive;

    // Update is called once per frame
    void Update()
    {
        if (waterActive)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level1;
        }

        if (transform.position.y >= 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level2;
        }

        if (transform.position.y >= 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level3;
        }

        if (transform.position.y >= 25)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level4;
        }

    }

    public void ActivateWater()
    {
        waterActive = true;
    }

}
