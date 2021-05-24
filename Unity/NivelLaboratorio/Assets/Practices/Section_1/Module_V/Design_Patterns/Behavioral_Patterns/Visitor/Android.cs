
using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public class Android : IAndroidPart
    {
        private IAndroidPart[] androidParts;

        public Android()
        {
            androidParts = new IAndroidPart[] { new Battery(), new Arms(), new Memory() };
        }

        public void Accept(IAndroidPartVisitor androidPartVisitor)
        {
            for (int i = 0; i < androidParts.Length; i++)
            {
                androidParts[i].Accept(androidPartVisitor);
            }
            androidPartVisitor.Visit(this);
        }
    }

}

