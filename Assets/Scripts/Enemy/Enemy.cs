using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private Player _target;

    public Player Target => _target;

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
        }
    }
}
