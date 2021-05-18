namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class SideWinder : Missile
    {
        private void Awake() 
        {
            this.seekBehaviour = new SeekWithHeat();
        }
    }

}