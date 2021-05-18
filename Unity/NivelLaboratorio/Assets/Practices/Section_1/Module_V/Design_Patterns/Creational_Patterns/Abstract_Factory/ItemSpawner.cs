using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class ItemSpawner : MonoBehaviour
    {
        private AbstractFactory factory;

        private IConsumable potion;
        private IConsumable food;
        private IUsable sword;
        private IUsable shield;

        public void SpawnUsables()
        {
            factory = FactoryProducer.GetFactory(FactoryType.Usable);

            sword = factory.GetUsableFactory(UsableType.Sword);
            shield = factory.GetUsableFactory(UsableType.Shield);

            sword.Use();
            shield.Use();
        }

        public void SpawnConsumables()
        {
            factory = FactoryProducer.GetFactory(FactoryType.Consumable);

            potion = factory.GetConsumableFactory(ConsumableType.Potion);
            food = factory.GetConsumableFactory(ConsumableType.Food);

            potion.Consume();
            food.Consume();
        }
    }

}
