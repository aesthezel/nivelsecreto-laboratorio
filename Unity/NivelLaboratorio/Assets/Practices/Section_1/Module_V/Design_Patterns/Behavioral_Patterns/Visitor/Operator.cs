using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public class Operator : MonoBehaviour
    {
        private IAndroidPart android = new Android();

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                android.Accept(new AndroidPartInitVisitor());
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                android.Accept(new AndroidPartHaltVisitor());
            }
        }
    }

}
