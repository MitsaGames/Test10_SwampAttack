using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected string _title;
    [SerializeField] protected int _cost;
    [SerializeField] protected float _shootTime;
    [SerializeField] protected Bullet _bulletTemplate;

    public float ShootTime => _shootTime;

    public void Shoot(ShootStartPoint shootStartPoint)
    {
        Instantiate(_bulletTemplate, shootStartPoint.transform.position, Quaternion.identity);
    }
}
