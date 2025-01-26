using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float timeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI timerTxt;
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            
            timeLeft += Time.deltaTime;
            updateTimer(timeLeft);
        }   
    }
    public void updateTimer(float currentTime)
    {
        currentTime++;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
