using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] float DestroyDelay = 0f;



    void OnCollisionEnter2D(Collision2D otherObj)
    {
  
            Destroy(gameObject, DestroyDelay);
        

    }
}
