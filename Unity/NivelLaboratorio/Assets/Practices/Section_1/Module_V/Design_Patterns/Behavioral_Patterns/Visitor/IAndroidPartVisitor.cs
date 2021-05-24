namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Visitor
{
    public interface IAndroidPartVisitor 
    {
        void Visit(Android android);
        void Visit(Arms arms);
        void Visit(Battery battery);
        void Visit(Memory memory);
    }

}