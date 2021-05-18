using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Factory
{
    public class CitizenSpawner : MonoBehaviour
    {
        public CitizenFactory Factory;

        private ICitizen banker;
        private ICitizen farmer;
        private ICitizen trader;
        private ICitizen driver;

        public void SpawnCitizens()
        {
            // Operación de prueba en la cual se instancian los 3 al mismo tiempo...

            banker = Factory.GetCitizen(CitizenType.Banker);
            farmer = Factory.GetCitizen(CitizenType.Farmer);
            trader = Factory.GetCitizen(CitizenType.Trader);
            driver = Factory.GetCitizen(CitizenType.Driver);


            banker.Dialogue();
            farmer.Dialogue();
            trader.Dialogue();
            driver.Dialogue();
        }
    }
}
