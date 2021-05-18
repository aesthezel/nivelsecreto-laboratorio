using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class Executor : MonoBehaviour // Player
    {
        public CitizenSpawner Spawner;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.S))
                Spawner.SpawnCitizens();
        }
    }
}
