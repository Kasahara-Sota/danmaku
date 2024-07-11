using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : ObjectBase
{
    /// <summary>É_ÉÅÅ[ÉWó </summary>
    [SerializeField] int _recoverLife;
    [SerializeField] float _rotationSpeed;
    public override void Move()
    {
        if (transform.parent)
        {
            Vector2 pos = this.transform.position;
            float x = this.transform.position.x - transform.parent.position.x;
            float y = this.transform.position.y - transform.parent.position.y;
            float r = Vector2.Distance(pos, transform.parent.position);
            float theta = Mathf.Atan2(y, x) + _rotationSpeed;
            x = Mathf.Cos(theta) * r + transform.parent.position.x;
            y = Mathf.Sin(theta) * r + transform.parent.position.y;
            pos = new Vector2(x, y);
            this.transform.position = pos;
        }
    }
    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
    }
}
