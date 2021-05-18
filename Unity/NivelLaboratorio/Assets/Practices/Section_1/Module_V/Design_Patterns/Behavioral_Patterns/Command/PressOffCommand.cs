namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class PressOffCommand : Command
    {
        public PressOffCommand(ActionButton reciver) : base(reciver)
        {
        }

        public override void Execute()
        {
            buttonReciver.PressOff();
        }
    }
}