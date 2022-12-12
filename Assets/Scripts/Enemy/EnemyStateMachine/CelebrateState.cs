using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrateState : State
{
    private Animator _animator;

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();

        _animator.Play("Minotaur_Celebrate");
    }
}
