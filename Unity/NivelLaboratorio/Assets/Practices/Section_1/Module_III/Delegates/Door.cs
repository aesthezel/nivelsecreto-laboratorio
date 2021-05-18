using UnityEngine;

public class Door : MonoBehaviour
{
    private bool open;
    private MeshRenderer meshRenderer;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable() 
    {
        MasterDelegate.OnStayInTheTrigger += EnableDoor;
    }

    private void Update() 
    {
        if (open)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, 20f, 0f), 0.5f);
    }

    void EnableDoor(bool option)
    {
        open = option;
    }

    private void OnDisable() 
    {
        MasterDelegate.OnStayInTheTrigger += EnableDoor;
    }
}
