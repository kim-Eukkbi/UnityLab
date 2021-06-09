using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;

    private Queue<GameObject> bulletQueue = new Queue<GameObject>();

    [SerializeField]
    private int bulletCount = 10;
    [SerializeField]
    private GameObject bulletPrefab = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        for(int i = 0; i < bulletCount; i++)
        {
            GameObject obj = Instantiate(bulletPrefab, transform);
            obj.SetActive(false);
            bulletQueue.Enqueue(obj);
        }
    }

    public GameObject GetBullet()
    {
        GameObject obj = bulletQueue.Peek();

        if (obj.activeSelf)
        {
            obj = Instantiate(bulletPrefab, transform);
        }
        else
        {
            obj = bulletQueue.Dequeue();
        }

        obj.SetActive(true);
        bulletQueue.Enqueue(obj);

        return obj;
    }
}
