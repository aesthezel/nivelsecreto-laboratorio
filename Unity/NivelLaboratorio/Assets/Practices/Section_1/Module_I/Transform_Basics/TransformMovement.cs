using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public float Speed;

    private float horizontal;
    private float vertical;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); // A = -1f \ D = 1f
        vertical = Input.GetAxis("Vertical"); // W = 1f / S = -1f

        transform.position += (new Vector3(horizontal, 0f, vertical) * Speed) * Time.deltaTime;

        // if ( Input.GetKey(KeyCode.W) )
        // {
        //     transform.position += (new Vector3(0f, 0f, 1f) * Speed) * Time.deltaTime;
        // }

        // if ( Input.GetKey(KeyCode.S) )
        // {
        //      transform.position += (new Vector3(0f, 0f, -1f) * Speed) * Time.deltaTime;
        // }

        // if ( Input.GetKey(KeyCode.A) )
        // {
        //      transform.position += (new Vector3(-1f, 0f, 0f) * Speed) * Time.deltaTime;
        // }

        // if ( Input.GetKey(KeyCode.D) )
        // {
        //      transform.position += (new Vector3(1f, 0f, 0f) * Speed) * Time.deltaTime;
        // }
    }
}
