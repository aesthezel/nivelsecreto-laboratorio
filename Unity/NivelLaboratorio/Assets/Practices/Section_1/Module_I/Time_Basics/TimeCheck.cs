using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    public Text FixedDeltaNumber;
    public Text DeltaNumber;
    public Text UnscaledDeltaNumber;

    private bool stopTime = false;
    private float normalTimeScale;

    void Start()
    {
        normalTimeScale = Time.timeScale;
    }

    void FixedUpdate()
    {
        FixedDeltaNumber.text = string.Format("{0:0.000}", Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        DeltaNumber.text = string.Format("{0:0.000}", Time.deltaTime);
        UnscaledDeltaNumber.text = string.Format("{0:0.000}", Time.unscaledDeltaTime);

        if(Input.GetKeyDown(KeyCode.P))
        {
            stopTime = !stopTime;
            Time.timeScale = stopTime ? float.Epsilon : normalTimeScale;
        }
    }
}
