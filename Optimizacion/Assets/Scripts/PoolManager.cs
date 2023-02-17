using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
    public string parentName;
    public GameObject prefab;
    public int size;
    public List<GameObject> pooledObjects;
    }

    public List<Pool> poolslist;
    
    public static PoolManager Instance;

    void Awake()
    {
        Instance = this;  
    }

    void Start()
    {
        GameObject obj;
        foreach (Pool pool in poolslist)
        {
            GameObject parent = new GameObject(pool.parentName);

            for (int i = 0;  i < pool.size; i++ )
            {
                obj = Instantiate(pool.prefab);
                obj.transform.SetParent(parent.transform);
                obj.SetActive(false);
                pool.pooledObjects.Add(obj);
            }
        }

    }

    public GameObject GetPooledObjects(int bulletType, Vector3 position, Quaternion rotation)
    {
        for (int i = 0; i < poolslist[bulletType].size; i++)
        {
            if(!poolslist[bulletType].pooledObjects [i].activeInHierarchy) 
            {
                GameObject objectToSpawn;
                objectToSpawn =  poolslist[bulletType].pooledObjects [i];
                objectToSpawn. transform.position = position;
                objectToSpawn. transform.rotation = rotation;
                return objectToSpawn;
            }
        }
        return null;
    }
}
