using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    public class Trap : MonoBehaviour
    {
        [SerializeField] private float damageAmount;

        private void OnTriggerEnter(Collider other) 
        {
            var damageable = other.GetComponent<IDamageable>();
            damageable?.Hit(damageAmount);
        }
    }
}