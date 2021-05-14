using UnityEngine;

namespace Practices.Section_1.Module_II.Interfaces
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float timeToDestroy;
        private Rigidbody _rigidbody;

        private void Awake() 
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            Destroy(this.gameObject, timeToDestroy);
        }

        private void Update()
        {
            _rigidbody.AddForce(Vector3.forward * speed, ForceMode.Acceleration);
        }
    }
}
