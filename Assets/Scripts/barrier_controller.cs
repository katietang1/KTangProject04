/*
Name: Katie Tang
Student ID#: 2313452
Chapman email: htang@chapman.edu
Course Number and Section: 236-03
Assignment: Project04 2D Space Shooter
This is my own work, and I did not cheat on this assignment.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_controller : MonoBehaviour
{

    private int health = 0;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            Destroy(this.gameObject);
            return;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        health++;
    }
}
