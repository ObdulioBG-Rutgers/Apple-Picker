using Unity.VisualScripting;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    private bool in_play = false;
    public GameObject apple;
    public GameObject bomb;
    public GameObject golden_apple;
    private BoxCollider spawn_area;
    private float apple_count = 0;

    private float countdown = 30f;
    private float time = 0f;

    void Start()
    {
        spawn_area = GetComponent<BoxCollider>();

        in_play = true;
    }

    void Update()
    {
        if (countdown <= 0)
        {
            in_play = false;
            
            // END SCRENE HERE <-----
        }

        if (!in_play) return;

        time += Time.deltaTime;

        if (time >= 1)
        {
            float rand_chance = Random.Range(1, 10);
            GameObject random_apple;
            
            if (rand_chance == 1 || apple_count >= 10)
            {
                random_apple = Instantiate<GameObject>(bomb);
                apple_count = 0;
            } else
            {
                random_apple = Instantiate<GameObject>(apple);
                apple_count += 1;
            }

            random_apple.transform.position = new Vector3(Random.Range(spawn_area.bounds.min.x, spawn_area.bounds.max.x), transform.position.y, Random.Range(spawn_area.bounds.min.z, spawn_area.bounds.max.z));

            countdown -= time;
            time = 0;
        }
        
    }
}
