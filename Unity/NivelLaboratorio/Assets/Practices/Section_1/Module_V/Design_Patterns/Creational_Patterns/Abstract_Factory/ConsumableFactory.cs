namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class ConsumableFactory : AbstractFactory
    {
        public override IConsumable GetConsumableFactory(ConsumableType consumableType)
        {
            switch (consumableType)
            {
                case ConsumableType.Potion:
                    IConsumable potion = new Potion();
                    return potion;
                case ConsumableType.Food:
                    IConsumable food = new Food();
                    return food;
            }
            return null;
        }

        public override IUsable GetUsableFactory(UsableType usableType)
        {
            return null;
        }
    }
}

