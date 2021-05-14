using UnityEngine;
using System.Collections;

namespace Practices.Section_1.Module_II.Interfaces
{
    public class Shooter : MonoBehaviour
    {

        [Header("* Shoot Preferences *")]
        [SerializeField] private KeyCode shootKey;
        [SerializeField] private Transform shootPoint;
        [SerializeField] private Transform projectile;
        [SerializeField] private float shootDelay;

        [Header("* Movement Preferences *")]
        [SerializeField] private float speed;

        private bool waitForShoot;
        private Rigidbody _rigidbody;
        private Vector3 nextPosition;
        private float horizontal;

        private void Awake() 
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate() 
        {
            Move();
        }
        private void Update() 
        {
            nextPosition = CheckHorizontalVector();
            PerformShoot();
        }

        private Vector3 CheckHorizontalVector()
        {
            horizontal = Input.GetAxis("Horizontal");

            return new Vector3(horizontal, 0f, 0f);
        }

        private void PerformShoot()
        {
            if(!waitForShoot && Input.GetKeyDown(shootKey))
            {
                waitForShoot = true;
                Instantiate(projectile, shootPoint.position, Quaternion.identity);
                StartCoroutine(PerformShootDelay(shootDelay));
                
            }
        }

        private IEnumerator PerformShootDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            waitForShoot = false;
        }

        private void Move()
        {
            _rigidbody.velocity = (nextPosition * speed) * Time.deltaTime;
        }
    }
}
