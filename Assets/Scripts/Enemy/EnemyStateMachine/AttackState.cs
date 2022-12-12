using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;

    private Animator _animator;
    private float _currentDelay = 0.0f;

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_currentDelay <= 0.0f)
        {

            _currentDelay = _delay;

            Target.ApplyDamage(_damage);
            _animator.Play("Minotaur_Shoot", -1, 0f);
        }

        _currentDelay -= Time.deltaTime;
    }
}
