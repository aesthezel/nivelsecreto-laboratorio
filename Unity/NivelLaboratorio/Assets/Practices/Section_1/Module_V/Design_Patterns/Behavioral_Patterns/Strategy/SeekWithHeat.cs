using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class SeekWithHeat : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Siguiendo mediante detección del calor...");
        }
    }

}