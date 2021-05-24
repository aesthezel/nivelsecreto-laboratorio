using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    public class VehicleOperator : MonoBehaviour
    {
        private readonly RaycastHit[] raycastMaxHits = new RaycastHit[5];

        [SerializeField] private Vehicle vehicle;
        [SerializeField] private LayerMask validLayers;
        [SerializeField] private float rayDistance;

        void Update()
        {
            CommandVehicleWithRayCast();
            //VerifyVehicleStatus();
        }

        private void CommandVehicleWithRayCast()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray hit = Camera.main.ScreenPointToRay(Input.mousePosition);
                int rayResult = Physics.RaycastNonAlloc(hit, raycastMaxHits, rayDistance, validLayers);

                if(rayResult > 0)
                {
                    for (int i = 0; i < rayResult; i++)
                    {
                        vehicle.GetAgent().destination = raycastMaxHits[i].point;
                    }
                }
            }
        }
    }

}
