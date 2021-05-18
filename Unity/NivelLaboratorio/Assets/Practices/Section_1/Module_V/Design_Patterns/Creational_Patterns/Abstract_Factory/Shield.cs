using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class Shield : IUsable
    {
        public void Use()
        {
            Debug.Log("El escudo, tu mejor apoyo...");
        }
    }
}
