using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private ShootStartPoint _shootStartPoint;

    private int _currentHealth;

    public int CurrentHealth => _currentHealth;
    public Weapon Weapon => _weapon;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if(_currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

    }

    public void Shoot()
    {
        _weapon.Shoot(_shootStartPoint);
    }
}
