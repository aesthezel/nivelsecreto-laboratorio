using UnityEngine;
using TMPro;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Observer
{
    public class TimeUI : MonoBehaviour
    {
        [SerializeField] private int secondsTimer;
        public int SecondsTimer { 
            get => secondsTimer; 
            set 
            {
                if(value <= Vector2Int.zero.x)
                    Timer.OnSecondPassed -= ReduceNumber;


                secondsTimer = Mathf.Max(Vector2Int.zero.x, value);
            } 
        }

        [SerializeField] private TMP_Text secondsText;

        private void OnEnable() 
        {
            Timer.OnTimerStarted += InitCounter;
            Timer.OnSecondPassed += ReduceNumber;
        }

        private void InitCounter () => secondsText.text = SecondsTimer.ToString();
        private void ReduceNumber () => secondsText.text = (--SecondsTimer).ToString();

        private void OnDisable() 
        {
            Timer.OnTimerStarted -= InitCounter;
            Timer.OnSecondPassed -= ReduceNumber;
        }
    }

}
