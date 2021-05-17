using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool open;

    private void OnEnable() 
    {
        MasterDelegate.OnDoAnything += EnableDoor;
    }

    private void Update() 
    {
        if (open)
            transform.Translate((Vector3.up * 5f) * Time.deltaTime);
    }

    void EnableDoor()
    {
        open = true;
    }

    private void OnDisable() 
    {
        MasterDelegate.OnDoAnything += EnableDoor;
    }
}
