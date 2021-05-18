using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public class Executor : MonoBehaviour
    {
        private void Update() 
        {
            if ( Input.GetKeyDown(KeyCode.Space) )
            {
                Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
                sideWinder.ApplySeek();

                Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
                tomahawk.ApplySeek();

                Missile torpedo = ScriptableObject.CreateInstance<Torpedo>();
                torpedo.ApplySeek();

                Missile sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
                ISeekBehaviour sonar = new SeekWithSonar();
                sideWinderWithSonar.SetSeekBehaviour(sonar);
                sideWinder.ApplySeek();
            }
        }
    }

}
