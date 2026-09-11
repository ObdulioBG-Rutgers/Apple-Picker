using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;
    public GameObject golden_apple;
    private BoxCollider spawn_area;
    private float time = 0f;

    void Start()
    {
        spawn_area = GetComponent<BoxCollider>();

        //for (int index = 0; index < 20; index ++)
        //{
        //    GameObject random_apple = Instantiate<GameObject>(apple);
        //    random_apple.transform.position = new Vector3(Random.Range(spawn_area.bounds.min.x, spawn_area.bounds.max.x),
        //                                                    transform.position.y,
        //                                                    Random.Range(spawn_area.bounds.min.z, spawn_area.bounds.max.z));
        //}
        

    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1)
        {
            Debug.Log("1 Second!");
            time = 0;
        }
        
    }
}
