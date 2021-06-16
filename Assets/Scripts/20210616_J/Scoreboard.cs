using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public List<Text> scoreTexts = new List<Text>();
    public List<ScoreInfo> scoreInfo = new List<ScoreInfo>();

    void Start()
    {
        for (int i = 0; i < scoreTexts.Count; i++)
        {
            scoreTexts[i].text = $"Name : {scoreInfo[i].name}, Score : {scoreInfo[i].score}";
        }
    }
}

[System.Serializable]
public class ScoreInfo
{
    public string name;
    public int score;
}