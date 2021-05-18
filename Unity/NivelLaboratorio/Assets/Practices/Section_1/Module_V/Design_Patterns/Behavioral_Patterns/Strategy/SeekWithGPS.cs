using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class SeekWithGPS : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Siguiendo mediante coordenadas en el GPS...");
        }
    }
}