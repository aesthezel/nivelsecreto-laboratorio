using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class SeekWithSonar : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Siguiendo mediante un sonar...");
        }
    }
}