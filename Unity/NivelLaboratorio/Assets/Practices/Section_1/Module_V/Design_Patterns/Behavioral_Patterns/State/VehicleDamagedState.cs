namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    public class VehicleDamagedState : IVehicleState
    {
        public void Execute(Vehicle vehicle)
        {
            vehicle.NotifyADebugMessage("El vehiculo ha recibido daños considerables...");

            if (vehicle.GetHealth() <= 0f)
            {
                vehicle.UnOperable();
            }
        }
    }
}
