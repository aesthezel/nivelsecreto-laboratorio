namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class Torpedo : Missile
    {
        private void Awake() 
        {
            this.seekBehaviour = new SeekWithSonar();
        }
    }
}

