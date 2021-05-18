using UnityEngine;

public class NPC : MonoBehaviour, ITargeteable
{
    public Transform GetMyTransform()
    {
        return transform;
    }
}
