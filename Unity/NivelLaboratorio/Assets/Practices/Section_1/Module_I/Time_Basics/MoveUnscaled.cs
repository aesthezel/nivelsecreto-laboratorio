using UnityEngine;
public class MoveUnscaled : MonoBehaviour
{
    public float Speed;
    private Vector3 direction = Vector3.zero;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            direction = Vector3.forward;
        }

        if(Input.GetKey(KeyCode.S))
        {
            direction = Vector3.back;
        }

        if(Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left;
        }

        if(Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right;
        }

        transform.Translate((direction * Speed) * Time.unscaledDeltaTime);

        direction = Vector3.zero;
    }
}
