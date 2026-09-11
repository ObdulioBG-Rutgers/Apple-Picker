using System;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
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
            AppleScript apple_script = game_object.GetComponent<AppleScript>();
            apple_script.on_destroy();
        }
    }


}
