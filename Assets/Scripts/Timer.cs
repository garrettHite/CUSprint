using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    private float startTime;
    private bool finished = false;
    static public string finalResult = "";
    string minutes;
    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;
        minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
    }
    public void Finish()
    {
        Debug.Log("help");
        finished = true;
        timerText.color = Color.yellow;
        finalResult = timerText.text;

    }

    static public string test()
    {
        return finalResult;
    }
}
