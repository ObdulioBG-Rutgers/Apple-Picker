using UnityEngine;

public class AppleScript : MonoBehaviour
{

    public GameObject shadow;

    void Start()
    {
        GameObject my_shadow = Instantiate<GameObject>(shadow);
        my_shadow.transform.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
