using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Prototype
{
    public class Entity : MonoBehaviour, ICopyable
    {
        public ICopyable Copy()
        {
            return Instantiate(this);
        }

    }
}

