using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Strategy
{
    public abstract class Missile : ScriptableObject
    {
        protected ISeekBehaviour seekBehaviour;

        public void ApplySeek()
        {
            seekBehaviour.Seek();
        }

        public void SetSeekBehaviour( ISeekBehaviour seekType )
        {
            this.seekBehaviour = seekType;
        }
    }
}