using System;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject game_object = other.gameObject;

        if (game_object.tag == "Apple")
        {
            score += 1;

        } else if (game_object.tag == "Bomb")
        {
            lives -= 1;

        } else if (game_object.tag == "Golden Apple")
        {
            score += 3;
        }

        AppleScript apple_script = game_object.GetComponent<AppleScript>();
        apple_script.on_destroy();

    }


}
