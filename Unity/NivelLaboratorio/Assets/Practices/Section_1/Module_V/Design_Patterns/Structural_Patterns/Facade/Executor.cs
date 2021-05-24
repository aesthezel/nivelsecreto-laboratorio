using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Facade
{
    public class Executor : MonoBehaviour
    {
        private Player player;

        private void Start() 
        {
            player = new Player();
        }

        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SaveSystem.Instance.SaveGame(player);
            }
        }
    }

}
