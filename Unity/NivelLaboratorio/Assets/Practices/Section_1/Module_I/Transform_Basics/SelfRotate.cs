using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotateDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = rotateDirection * Time.deltaTime;
        transform.Rotate(rotation.x, rotation.y, rotation.z);
    }
}
