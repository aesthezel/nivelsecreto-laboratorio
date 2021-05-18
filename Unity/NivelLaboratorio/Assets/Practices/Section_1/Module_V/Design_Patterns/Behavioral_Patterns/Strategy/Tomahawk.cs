namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class Tomahawk : Missile
    {
        private void Awake() 
        {
            seekBehaviour = new SeekWithGPS();
        }
    }

}
