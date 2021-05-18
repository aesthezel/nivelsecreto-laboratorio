namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class Invoker
    {
        private Command command;
        
        public void SetCommand ( Command command )
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
