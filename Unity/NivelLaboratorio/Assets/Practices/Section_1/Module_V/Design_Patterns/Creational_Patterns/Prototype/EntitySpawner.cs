using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Prototype
{
    public class EntitySpawner : MonoBehaviour
    {
        public ICopyable Copy;

        public Entity SpawnEntity( Entity prototype )
        {
            Copy = prototype.Copy();
            return (Entity)Copy;
        }
    }
}
