using System;
using System.Text.RegularExpressions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BasketScript : MonoBehaviour
{
    public GameObject score_label;
    private TMP_Text score_text;

    public GameObject lives_label;
    private TMP_Text lives_text;


    public int score = 0;
    public int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score_text = score_label.GetComponent<TMP_Text>();
        lives_text = lives_label.GetComponent<TMP_Text>();
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

        score_text.text = "Score : " + score.ToString();
        lives_text.text = "Lives : " + lives.ToString();

    }


}
