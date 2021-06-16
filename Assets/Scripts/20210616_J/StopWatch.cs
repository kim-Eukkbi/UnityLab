using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public Text stopWatchTxt = null;
    float currentTime = 0f;


    private void Update()
    {
        currentTime += Time.deltaTime;

        // 1. Time.deltaTime만 쓰세요 DateTime같은거 쓰지 마세요.
        // 2. 코루틴 안됨
        // 3. 변수 추가 가능
        // 4. 어떻게든 만들면 되는데 가장 매력적인 코드면 토큰 드림
    }
}
