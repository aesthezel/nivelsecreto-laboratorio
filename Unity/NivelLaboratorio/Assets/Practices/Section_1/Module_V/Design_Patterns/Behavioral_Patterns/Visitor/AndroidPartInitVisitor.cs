using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public class AndroidPartInitVisitor : IAndroidPartVisitor
    {
        public void Visit(Arms arms)
        {
            Debug.Log("Brazos calibrados...");
        }

        public void Visit(Battery battery)
        {
            Debug.Log("Bateria totalmente cargada...");
        }

        public void Visit(Memory memory)
        {
            Debug.Log("Memoria depurada e inicializada...");
        }

        public void Visit(Android android)
        {
            Debug.Log("El Android esta inicializado en la version 1.2");
        }
    }

}
