using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class Farmer : ICitizen
    {
        public void Dialogue()
        {
            Debug.Log("Harar, cortar, cosechar...");
        }
    }
}
