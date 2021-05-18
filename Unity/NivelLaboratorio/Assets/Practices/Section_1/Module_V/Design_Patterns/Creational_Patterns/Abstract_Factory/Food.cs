using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class Food : IConsumable
    {
        public void Consume()
        {
            Debug.Log("Comiendo esta comida...");
        }
    }

}

