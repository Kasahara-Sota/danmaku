using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    
    private void FixedUpdate()
    {    
        Move();
    }
    public abstract void Activate();
    public abstract void Move();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {      
                Activate();
        }
    }
}
