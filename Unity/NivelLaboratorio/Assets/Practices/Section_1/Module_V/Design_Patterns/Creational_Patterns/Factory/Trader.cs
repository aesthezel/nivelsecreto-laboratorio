using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class Trader : ICitizen
    {
        public void Dialogue()
        {
            Debug.Log("¿Algo util para cambiar?");
        }
    }

}
