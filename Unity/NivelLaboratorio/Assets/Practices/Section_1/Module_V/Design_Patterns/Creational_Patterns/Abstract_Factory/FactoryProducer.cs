namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public enum FactoryType
    {
        Consumable,
        Usable
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory ( FactoryType factoryType )
        {
            switch (factoryType)
            {
                case FactoryType.Consumable:
                    AbstractFactory consumableFactory = new ConsumableFactory();
                    return consumableFactory;
                case FactoryType.Usable:
                    AbstractFactory usableFactory = new UsableFactory();
                    return usableFactory;
            }
            return null;
        }
    }
}

