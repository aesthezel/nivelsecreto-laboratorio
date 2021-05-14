using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text CounterText;
    public Button RestartButton;

    private void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ChangeStatusOfRestartButton( bool status )
    {
        RestartButton.enabled = status;
    }

    public void ChangeStatusOfCounterText( string status )
    {
        CounterText.text = status;
    }
}
