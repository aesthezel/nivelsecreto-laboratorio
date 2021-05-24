namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.State
{
    public class VehicleUnOperableState : IVehicleState
    {
        public void Execute(Vehicle vehicle)
        {
            vehicle.NotifyADebugMessage("El vehiculo ya no sirve para nada...");
            vehicle.SetOperable(false);
            vehicle.GetAgent().speed = 0f;
        }
    }
}