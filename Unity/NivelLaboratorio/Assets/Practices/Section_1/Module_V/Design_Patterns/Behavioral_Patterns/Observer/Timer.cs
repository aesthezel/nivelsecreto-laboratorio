using System.Collections;
using UnityEngine;

namespace Practices.Section_1.Module_V.Design_Patterns.Behavioral_Patterns.Observer
{
    public class Timer : MonoBehaviour
    {
        private float duration = 200f;
        private float halfTime;

        public delegate void TimerStarted();
        public static event TimerStarted OnTimerStarted;

        public delegate void SecondPassed();
        public static event SecondPassed OnSecondPassed;

        public delegate void HalfTime();
        public static event HalfTime OnHalfTime;

        public delegate void TimerEnded();
        public static event TimerEnded OnTimerEnded;

        private IEnumerator timerCoroutine;

        // Start is called before the first frame update
        private IEnumerator Start()
        {
            halfTime = duration / 2f;

            if (OnTimerStarted != null)
                OnTimerStarted();

            yield return StartCoroutine(WaitAndPrint(1f));

            if (OnTimerEnded != null)
                OnTimerEnded();
        }

        private IEnumerator WaitAndPrint(float time)
        {
            while (Time.time < duration)
            {
                yield return new WaitForSeconds(time);
                
                if(OnSecondPassed != null)
                    OnSecondPassed();


                if ( Mathf.Round(Time.deltaTime) == Mathf.Round(halfTime) )
                {
                    if (OnHalfTime != null)
                        OnHalfTime();
                }
            }
        }

    }

}

