using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Prototype
{
    public class PrototypeClient : MonoBehaviour
    {
        public Warrior WarriorPrototype;
        public Wizard WizardPrototype;
        public EntitySpawner Spawner;

        private Entity spawn;
        private int identifierWarrior = 0;
        private int identifierWizard = 0;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                spawn = Spawner.SpawnEntity(WarriorPrototype);
                spawn.name = "Warrior_Clone_" + ++identifierWarrior;
                spawn.transform.Translate(Vector3.forward * identifierWarrior * 2f);
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                spawn = Spawner.SpawnEntity(WizardPrototype);
                spawn.name = "Wizard_Clone_" + ++identifierWizard;
                spawn.transform.Translate(Vector3.forward * identifierWizard * 2f);
            }
        }

    }
}
