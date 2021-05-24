namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public interface IAndroidPart 
    {
        void Accept( IAndroidPartVisitor androidPartVisitor );
    }

}
