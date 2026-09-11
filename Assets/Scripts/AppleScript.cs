using UnityEngine;

public class AppleScript : MonoBehaviour
{

    public GameObject shadow;
    private GameObject my_shadow;

    void Start()
    {
        my_shadow = Instantiate<GameObject>(shadow);
        my_shadow.transform.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_destroy()
    {
        Destroy(my_shadow);
        Destroy(gameObject);
    }
}
