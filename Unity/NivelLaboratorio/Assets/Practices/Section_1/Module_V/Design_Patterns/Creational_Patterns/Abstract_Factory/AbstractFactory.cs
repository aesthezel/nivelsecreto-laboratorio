namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public enum ConsumableType
    {
        Potion,
        Food
    }

    public enum UsableType
    {
        Sword,
        Shield
    }

    public abstract class AbstractFactory
    {
        public abstract IConsumable GetConsumableFactory ( ConsumableType consumableType );
        public abstract IUsable GetUsableFactory ( UsableType usableType );
    }
}
