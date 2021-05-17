using UnityEngine;

public class MasterDelegate : MonoBehaviour
{

    // Pueden ser vacios o devolver un valor.
    // Para construirlo se usan bloques de codigo entre {} y para ejecutarlos se llama por su nombre y parentesis () en donde pasamos los parametros.
    // Parametros son intrucciones, logica que va utilizar y que proviene de un exterior o tercero y son obligatorios al completar.

    // DELEGATES
    // Por suscripcion y tienen la porpiedad de asignar metodos en su variable
    // Incluso los delegados pueden contener multiples metodos en su variable de ejecucion

    public delegate void DoAnything();
    // Variable de nuestro delegado
    public static event DoAnything OnDoAnything;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.name == "Target")
            OnDoAnything();

    }
}