using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralyze : ObjectBase
{
    public override void Move()
    {
    }
    public override void Activate()
    {
        FindObjectOfType<PlayerController>().Paralize();
        Destroy(this.gameObject);
    }
}
