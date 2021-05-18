
using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class Executer : MonoBehaviour
    {
        public ItemSpawner Spawner;
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
                Spawner.SpawnConsumables();

            if(Input.GetKeyDown(KeyCode.Alpha2))
                Spawner.SpawnUsables();
        }
    }

}
