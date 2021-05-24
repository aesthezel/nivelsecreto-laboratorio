using UnityEngine;
using UnityEngine.UI;

namespace TestZone
{
    public class ButtonTest : MonoBehaviour
    {
        public Button primaryButton;
        public Button[] commandButtons;

        void Start()
        {
            primaryButton.onClick.AddListener( () => {

                foreach (var button in commandButtons)
                {
                    button.onClick.Invoke();
                }

            });
        }

        
        void Update()
        {
            
        }
    }
    
}

