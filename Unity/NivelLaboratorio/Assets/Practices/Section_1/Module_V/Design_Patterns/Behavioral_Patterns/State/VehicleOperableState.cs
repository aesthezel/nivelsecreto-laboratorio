namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    public class VehicleOperableState : IVehicleState
    {
        public void Execute(Vehicle vehicle)
        {
            vehicle.NotifyADebugMessage("¡El vehiculo esta en una buena condición!");
            vehicle.SetOperable(true);
        }
    }

}
