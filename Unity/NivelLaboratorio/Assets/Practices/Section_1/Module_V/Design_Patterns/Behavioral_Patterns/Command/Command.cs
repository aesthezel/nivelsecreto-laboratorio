namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public abstract class Command
    {
        protected ActionButton buttonReciver;

        public Command (ActionButton reciver)
        {
            buttonReciver = reciver;
        }

        public abstract void Execute();
    }

}

