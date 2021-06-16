using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        posQueue.Enqueue(transform.position);

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

        Move();
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if (posQueue.Peek().Equals(transform.position)) return;

        if(posQueue.Count <= 100)
            posQueue.Enqueue(transform.position);

        if (posQueue.Count > 100)
        {
            petObj.transform.position = posQueue.Dequeue();
        }
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y).normalized * 3f * Time.deltaTime;
    }
}
