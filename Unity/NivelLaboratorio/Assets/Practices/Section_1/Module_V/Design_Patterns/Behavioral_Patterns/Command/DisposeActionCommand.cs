namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class DisposeActionCommand : Command
    {
        private ActionButton[] actionButtons;
        private static ActionButton reciver;

        public DisposeActionCommand(ActionButton[] buttons) : base(reciver)
        {
            actionButtons = buttons;
        }

        public override void Execute()
        {
            foreach (var buttons in actionButtons)
            {
                buttons.PressOff();
            }
        }
    }
}
