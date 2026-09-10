using UnityEngine;

public class CharacterClass : MonoBehaviour
{
    private float speed = 7;
    private float rotate = 10;

    private Rigidbody rigid_body;

    private void Start()
    {
        rigid_body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 input_map = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            input_map.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input_map.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input_map.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input_map.x += 1;
        }

        input_map = input_map.normalized;

        Vector3 velocity = new Vector3(input_map.x, 0f, input_map.y);
        rigid_body.linearVelocity = velocity * speed;

        transform.forward = Vector3.Slerp(transform.forward, velocity, rotate * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log("HHHHHH");
        GameObject collided_with = other.gameObject;

        if (collided_with.tag == "Apple")
        {
            Debug.Log("Collided!");
            Destroy(collided_with);
        }
    }
}
