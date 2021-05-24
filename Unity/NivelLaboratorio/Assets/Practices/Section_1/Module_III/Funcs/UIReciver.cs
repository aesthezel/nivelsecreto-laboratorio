using System;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class UIReciver : MonoBehaviour
{
    public Button SuperButton;

    void Start()
    {

        SuperButton.onClick.AddListener(
            async () => {

                await SayAnything();

                Debug.Log("Termine No Async");
            }
        );

    }


    async Task SayAnything()
    {
        await Task.Run( ()=> {
            
            for (int i = 0; i < 300; i++)
            {
                if(i == 150)
                {
                    Debug.Log("Voy por la mitad del Task");
                }
                
                
            }

            Debug.Log("Termine Async");

        });
    }


    // Update is called once per frame
    void LambdaAnnounce () => Debug.Log("Hola soy un Lambda en forma de Expression Body");

    public void Multiply (int number1, int number2)
    {
        Debug.Log("Se ha multiplicado" + (number1 + number2));
    }

    public int Sum( int a, int b)
    {
        return a + b;
    }
}
