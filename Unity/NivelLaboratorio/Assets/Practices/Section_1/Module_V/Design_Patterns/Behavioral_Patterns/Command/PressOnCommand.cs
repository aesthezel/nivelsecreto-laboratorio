namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class PressOnCommand : Command
    {
        public PressOnCommand(ActionButton reciver) : base(reciver)
        {
        }

        public override void Execute()
        {
            buttonReciver.PressOn();
        }
    }
}