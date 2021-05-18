using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class Sword : IUsable
    {
        public void Use()
        {
            Debug.Log("La espada, para un gran ataque...");
        }
    }
}
