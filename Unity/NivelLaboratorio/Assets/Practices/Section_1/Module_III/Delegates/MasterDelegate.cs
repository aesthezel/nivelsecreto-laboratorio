using UnityEngine;
using System;

public class MasterDelegate : MonoBehaviour
{
    public static Action<bool, Color, ITargeteable> OnTargetAppears;
    public static Action<bool> OnStayInTheTrigger;

    private void OnTriggerEnter(Collider other)
    {
        ITargeteable target = other.gameObject.GetComponent<ITargeteable>();

        if (target != null)
            OnTargetAppears(true, Color.yellow, target);  // Enemies
            OnStayInTheTrigger(true);                               // Door
    }
}