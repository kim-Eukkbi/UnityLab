using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector2 minPos;     // 카메라의 제일 하단쪽의 위치
    private Vector2 maxPos;     // 카메라의 제일 상단쪽의 위치

    void Start()
    {
        minPos = Camera.main.ViewportToWorldPoint(Vector2.zero);
        maxPos = Camera.main.ViewportToWorldPoint(Vector2.one);
    }

    void Update()
    {
        transform.Translate(Vector3.up * 10f * Time.deltaTime);

        if (transform.position.y > maxPos.y)
        {
            gameObject.SetActive(false);
        }
    }
}
