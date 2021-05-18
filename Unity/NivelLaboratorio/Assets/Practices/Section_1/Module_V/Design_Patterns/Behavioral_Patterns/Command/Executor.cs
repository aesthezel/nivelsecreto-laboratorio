using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Command
{
    public class Executor : MonoBehaviour
    {
        private ActionButton liftReciver;
        private ActionButton[] actionButtons = new ActionButton[1];

        private void Start() 
        {
            liftReciver = new LiftReciver();
            actionButtons[0] = liftReciver;    
        }

        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Command commandLift = new PressOnCommand(actionButtons[0]);

                Invoker invoker = new Invoker();

                invoker.SetCommand(commandLift);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Command commandDispose = new DisposeActionCommand(actionButtons);

                Invoker invoker = new Invoker();

                invoker.SetCommand(commandDispose);
                invoker.ExecuteCommand();
            }
        }
    }

}

