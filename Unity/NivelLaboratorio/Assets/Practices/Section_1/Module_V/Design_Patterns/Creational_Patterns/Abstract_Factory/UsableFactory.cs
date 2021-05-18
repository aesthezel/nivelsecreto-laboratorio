namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class UsableFactory : AbstractFactory
    {
        public override IConsumable GetConsumableFactory(ConsumableType consumableType)
        {
            return null;
        }

        public override IUsable GetUsableFactory(UsableType usableType)
        {
            switch (usableType)
            {
                case UsableType.Shield:
                    IUsable shield = new Shield();
                    return shield;
                case UsableType.Sword:
                    IUsable sword = new Sword();
                    return sword;
            }
            return null;
        }
    }
}
