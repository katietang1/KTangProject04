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
using UnityEngine.UI;

public class score_controller : MonoBehaviour
{
    public int score = 0;

    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
    }
}
