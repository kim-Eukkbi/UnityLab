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

        // 1. Time.deltaTime�� ������ DateTime������ ���� ������.
        // 2. �ڷ�ƾ �ȵ�
        // 3. ���� �߰� ����
        // 4. ��Ե� ����� �Ǵµ� ���� �ŷ����� �ڵ�� ��ū �帲
    }
}