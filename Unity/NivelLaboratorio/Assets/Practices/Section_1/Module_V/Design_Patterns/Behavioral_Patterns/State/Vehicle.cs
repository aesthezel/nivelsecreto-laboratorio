using UnityEngine;
using UnityEngine.AI;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Vehicle : MonoBehaviour, IDamageable
    {
        [SerializeField] private bool operable;
        [SerializeField] private float health;
        private NavMeshAgent agent;
        private IVehicleState currentState;

        #region Old-Fashioned Getters & Setters
        public NavMeshAgent GetAgent() => agent;
        public float GetHealth () => health;
        public void SetOperable (bool status) => operable = status;
        #endregion

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();

            currentState = new VehicleOperableState();
            currentState.Execute(this);
        }

        public void Operable()
        {
            currentState = new VehicleOperableState();
            currentState.Execute(this);
        }

        public void UnOperable()
        {
            currentState = new VehicleUnOperableState();
            currentState.Execute(this);
        }

        public void Damaged()
        {
            currentState = new VehicleDamagedState();
            currentState.Execute(this);
        }

        public void NotifyADebugMessage( string message )
        {
            Debug.Log(message);
        }

        public void Hit(float quantity)
        {
            if (operable)
            {   
                health -= quantity;
                Damaged();
            }
        }
    }
}

