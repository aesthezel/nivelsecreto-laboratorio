using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public class AndroidPartHaltVisitor : IAndroidPartVisitor
    {
        public void Visit(Arms arms)
        {
            Debug.Log("Liberando presion hidraulica en brazos...");
        }

        public void Visit(Battery battery)
        {
            Debug.Log("Descargando sobrecarga de bateria, apagando...");
        }

        public void Visit(Memory memory)
        {
            Debug.Log("Memoria liberada y programada depuracion...");
        }

        public void Visit(Android android)
        {
            Debug.Log("El Android se ha desconectado...");
        }
    }

}
