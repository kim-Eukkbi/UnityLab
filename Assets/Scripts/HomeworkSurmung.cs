using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkSurmung : MonoBehaviour
{
    private void Start()
    {
        // 1. bullet.Enqueue()를 써서 처음에 bulletPrefab을 10개정도 저장시킨다. -> 저장시킨거는 PoolManager의 자식이 되도록

        // 2. PoolManager에 bullet큐에서 현재 queue에서 안쓰고 있는(비활성화되어있는) 오브젝트를 찾아서 반환해주는 함수를 만든다.
        //    단 다 활성화가 되어있으면 새로 만들어서 현재 queue에 추가를 하고 만든 거를 반환해준다.

        // 3. 이 만든 함수를 PlayerScript에서 Space를 누를 시 불러가지고 쏘시면 됩니다.
    }
}