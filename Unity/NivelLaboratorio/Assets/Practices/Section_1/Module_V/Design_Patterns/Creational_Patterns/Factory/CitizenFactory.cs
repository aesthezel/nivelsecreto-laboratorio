using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public enum CitizenType
    {
        Banker,
        Farmer,
        Trader,
        Driver
    }

    public class CitizenFactory : MonoBehaviour
    {
        public ICitizen GetCitizen (CitizenType type)
        {
            switch (type)
            {
                case CitizenType.Banker:
                    ICitizen banker = new Banker();
                    return banker;
                case CitizenType.Farmer:
                    ICitizen farmer = new Farmer();
                    return farmer;
                case CitizenType.Trader:
                    ICitizen trader = new Trader();
                    return trader;
                case CitizenType.Driver:
                    ICitizen driver = new Driver();
                    return driver;
            }
            return null;
        }
    }
}

