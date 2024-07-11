using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GenerateDir
{
    right,
    left,
    straight
}
public class Generate : MonoBehaviour
{
    /// <summary>発射するオブジェクト</summary>
    [SerializeField] GameObject[] _prehubs;
    [SerializeField] float _interval;
    private Vector2 _position;
    private GameObject _obj;
    private Rigidbody2D _rb;
    private Vector2 _vec;
    private int _power;
    private float _timer;
    /// <summary>発射方向</summary>
    [SerializeField] GenerateDir _dir;
    void Start()
    {
        _position = transform.position;
    }


    void Update()
    {
        _timer += Time.deltaTime;
        if(_interval<_timer)
        {
            _obj = Instantiate(_prehubs[Random.Range(0,_prehubs.Length)], _position, Quaternion.identity) as GameObject;
            _rb = _obj.GetComponent<Rigidbody2D>();
            _vec.x = Random.Range(5, 10);
            if (_dir == GenerateDir.left)
                _vec.x *= -1;
            else if (_dir == GenerateDir.straight)
                _vec.x = Random.Range(-10, 10); ;
            _vec.y = Random.Range(5, 10) * -1;
            _power = Random.Range(5, 15);
            _rb.AddForce(_vec.normalized * _power, ForceMode2D.Impulse);
            _timer = 0;
        }
    }
}
