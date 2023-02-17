using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public Transform gunPosition;
    public int ammoType;
    
    void Update()
    {
      if(Input.GetButtonDown("Fire1"))
      {
        GameObject bullet = PoolManager.Instance.GetPooledObjects(ammoType, gunPosition.position, gunPosition.rotation);
        bullet.SetActive(true);
      }  
    }
}
