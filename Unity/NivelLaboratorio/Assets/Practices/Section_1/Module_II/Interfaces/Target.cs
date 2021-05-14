using UnityEngine;

namespace Practices.Section_1.Module_II.Interfaces
{
    public class Target : MonoBehaviour
    {
        private RailManager railManager;
        private Transform pointToMove;
        private float maxDistanceDelta;

        private bool canMove;

        public void SetRailManager( RailManager rail )
        {
            railManager = rail;
        }

        private void Update()
        {
            MoveToTheEnd();
        }

        private void MoveToTheEnd()
        {
            if(!canMove)
                return;

            float totalMagnitude = (transform.position - pointToMove.position).magnitude;

            if(totalMagnitude > float.Epsilon)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, pointToMove.position, maxDistanceDelta * Time.deltaTime);
            }
            else
            {
                railManager.ResetTarget(this);
            }
        }

        public void SetPointAndDistance(Transform point, float distance)
        {
            pointToMove = point;

            Vector3 pointWithStaticY = new Vector3(pointToMove.position.x, transform.position.y, pointToMove.position.z);
            pointToMove.position = pointWithStaticY;

            maxDistanceDelta = distance;

            if(point != null && distance > 0)
            {
                canMove = true;
            }
        }
    }
}