using UnityEngine;

public class AppleScript : MonoBehaviour
{

    public GameObject shadow;
    private GameObject my_shadow;
    private Vector3 target_scale = new Vector3(1, 0.01f, 1);

    void Start()
    {
        my_shadow = Instantiate<GameObject>(shadow);
        my_shadow.transform.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        my_shadow.transform.localScale = Vector3.Lerp(my_shadow.transform.localScale, target_scale, Time.deltaTime * 1);
    }

    public void on_destroy()
    {
        Destroy(my_shadow);
        Destroy(gameObject);
    }
}
