using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player _player;

    private float _currentShootTime = 0.0f;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_currentShootTime <= 0)
            {
                _currentShootTime = _player.Weapon.ShootTime;
                _player.Shoot();
            }
        }

        _currentShootTime -= Time.deltaTime;
    }
}
