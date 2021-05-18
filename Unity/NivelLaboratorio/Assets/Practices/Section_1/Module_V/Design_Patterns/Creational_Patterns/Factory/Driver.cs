using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class Driver : ICitizen
    {
        public void Dialogue()
        {
            Debug.Log("¿A dónde quiere ir?");
        }
    }
}