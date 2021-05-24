namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public class Arms : IAndroidPart
    {
        public void Accept(IAndroidPartVisitor androidPartVisitor)
        {
            androidPartVisitor.Visit(this);
        }
    }
    
}

