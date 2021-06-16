using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public Text stopWatchTxt = null;
    public float currentTime = 0f;


    private void Update()
    {
        currentTime += Time.deltaTime;
       
        int min = (int)currentTime / 60;
        int hour = (int)currentTime / (60 * 60);

        stopWatchTxt.text = $"{hour % 60}:{(min % 60).ToString("00")}:{(currentTime % 60).ToString("00.00")}";
    }
}
