using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public GameObject time_label;
    private TMP_Text time_text;

    public GameObject end_screen;
    private TMP_Text end_text;

    public GameObject basket;
    private BasketScript basket_script;

    private bool in_play = false;
    public GameObject apple;
    public GameObject bomb;
    public GameObject golden_apple;
    private BoxCollider spawn_area;
    private float apple_to_bomb_count = 0;
    private float apple_to_gold_count = 0;

    private float countdown = 30f;
    private float time = 0f;

    void Start()
    {
        spawn_area = GetComponent<BoxCollider>();
        basket_script = basket.GetComponent<BasketScript>();

        time_text = time_label.GetComponent<TMP_Text>();

        end_text = end_screen.GetComponent<TMP_Text>();

        in_play = true;
    }

    void Update()
    {
        time_text.text = "Time : " + countdown.ToString("F0");

        if (countdown <= 0 || basket_script.lives <= 0 ) 
        {
            in_play = false;
            
            end_screen.SetActive(true);
            end_text.text = "Final Score: " + (basket_script.score * basket_script.lives).ToString();
        }

        if (!in_play) return;

        time += Time.deltaTime;

        if (time >= 1)
        {
            if (countdown <= 4)
            {
                countdown -= time;
                time = 0;
                return;
            }

            float rand_chance = Random.Range(1, 10);
            GameObject random_apple;

            if (rand_chance == 1 || apple_to_bomb_count >= 10)
            {
                random_apple = Instantiate<GameObject>(bomb);
                apple_to_bomb_count = 0;

            } else if (apple_to_gold_count >= 15) {
                random_apple = Instantiate<GameObject>(golden_apple);
                apple_to_gold_count = 0;

            } else
            {
                random_apple = Instantiate<GameObject>(apple);
                apple_to_bomb_count += 1;
                apple_to_gold_count += 1;
            }

            random_apple.transform.position = new Vector3(Random.Range(spawn_area.bounds.min.x, spawn_area.bounds.max.x), transform.position.y, Random.Range(spawn_area.bounds.min.z, spawn_area.bounds.max.z));

            countdown -= time;
            time = 0;
        }
        
    }
}
