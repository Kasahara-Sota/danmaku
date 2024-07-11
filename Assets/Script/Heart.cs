using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : ObjectBase
{
    /// <summary>‰ñ•œ—Ê</summary>
    [SerializeField] int _recoverLife;
    [SerializeField] float _width;
    private Vector2 _pos;
    private float _theta;
    private int _speed ;
    private void Start()
    {
        _speed = Random.Range(0, 5);
    }
    public override void Move()
    {
        _theta += Time.deltaTime;
        _pos = transform.position;
        _pos.x += Mathf.Cos(_theta*_speed)*_width;
        transform.position = _pos;
    }
    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
        FindObjectOfType<PlayerController>().Cure();
        Destroy(this.gameObject);
    }
}
