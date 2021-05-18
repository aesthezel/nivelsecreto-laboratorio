using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class Banker : ICitizen
    {
        public void Dialogue()
        {
            Debug.Log("Dame tu dinero, yo lo guardare de una manera muy segura...");
        }
    }

}


