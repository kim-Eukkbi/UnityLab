using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkSurmung : MonoBehaviour
{
    private void Start()
    {
        // Queue문제 종합 세트

        // Homework 01
        // 1. bullet.Enqueue()를 써서 처음에 bulletPrefab을 10개정도 저장시킨다. -> 저장시킨거는 PoolManager의 자식이 되도록
        // 2. PoolManager에 bullet큐에서 현재 queue에서 안쓰고 있는(비활성화되어있는) 오브젝트를 찾아서 반환해주는 함수를 만든다.
        //    단 다 활성화가 되어있으면 새로 만들어서 현재 queue에 추가를 하고 만든 거를 반환해준다.
        // 3. 이 만든 함수를 PlayerScript에서 Space를 누를 시 불러가지고 쏘시면 됩니다.
        // 4. foreach 안쓰고 Peek 쓰면 됩니다. Peek은 현재 큐에서 맨 첫번째애의 값을 반환해준다.(Queue에서 빼진 않고)
        // 5. 총알이 화면 밖으로 나가면 SetActive를 false로 해준다








        // Homework 02
        // 플레이어를 따라오는 펫 만들기

        // 1. 플레이어의 이동 만들기 (wasd로 이동 noralize가 잘 되있는지 체크할거임)
        // 2. 펫은 플레이어가 이동한 경로를 따라서 이동하는데 약간 간격을 두고 플레이어가 움직이면은 이동한다.
        // 3. Queue를 이용하여 구현
        // 4. foreach 절대 쓰지 말것
    }
}










