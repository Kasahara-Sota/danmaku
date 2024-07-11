using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject table ;
    int n = 5;
    float dig;
    float x;
    float y;
    float r = 3;
    
    void Start()
    {
        
        for (int j = 0; j < 10; j++)
        {
            dig = 2f * Mathf.PI / n;

            float theta = 0;

            for (int i = 0; i < n; i++)
            {
                y = r * Mathf.Sin(theta) + transform.position.y;
                x = r * Mathf.Cos(theta) + transform.position.x;
                GameObject Obj;
                Obj =(GameObject) Instantiate(table, new Vector2(x,y), Quaternion.identity/*EulerRotation(0, 0, 90)*/);
                Obj.transform.parent = transform;
                theta += dig;
            }
            r += 5;
            n += 4;
        }
    }
}