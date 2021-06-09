using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject petPrefab = null;
    private GameObject petObj = null;

    private Queue<Vector2> posQueue = new Queue<Vector2>();

    void Start()
    {
        //print(Camera.main.ViewportToWorldPoint(Vector2.zero));
        //print(Camera.main.ViewportToWorldPoint(Vector2.one));

        petObj = Instantiate(petPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 총알을 발사 -> 총알을 발사하는 위치에서
            GameObject obj = PoolManager.instance.GetBullet();
            obj.transform.position = transform.position;
        }
    }

    void FollowPlayer()
    {
        
    }
}
