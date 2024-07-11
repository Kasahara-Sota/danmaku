using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody2D m_rb;
    private enum Status
    {
        normal,
        Paralized
    }
    private Status status;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;
        if (status == Status.normal)
        {
            m_rb.velocity = dir * _moveSpeed;
        }
        else
        {
            m_rb.velocity = dir * _moveSpeed / 2;
        }
    }
    public void Paralize()
    {
        status = Status.Paralized;
    }
    public void Cure()
    {
        status = Status.normal;
    }
}
