using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    
    void Update()+
    {
        transform.position += transform.forward * 5 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other) 
    {
        this.gameObject.SetActive(false);
    }
}
