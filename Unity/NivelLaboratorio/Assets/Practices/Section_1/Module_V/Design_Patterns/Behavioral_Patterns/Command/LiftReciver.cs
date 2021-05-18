using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class LiftReciver : ActionButton
    {
        public override void PressOff()
        {
            Debug.Log("El ascensor se ha detenido.");
        }

        public override void PressOn()
        {
            Debug.Log("El ascensor se dirige al piso...");
        }
    }

}

