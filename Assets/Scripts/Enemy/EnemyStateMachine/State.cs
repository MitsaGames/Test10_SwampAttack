using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyStateMachine))]
public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transisions;

    protected Player Target;

    private void Start()
    {
    }

    public void Enter(Player target)
    {
        if (enabled == false)
        {
            enabled = true;
            Target = target;

            foreach (var transition in _transisions)
            {
                transition.enabled = true;
                transition.Init(target);
            }
        }
    }

    public void Exit()
    {
        if (enabled == true)
        {
            foreach (var transition in _transisions)
            {
                transition.enabled = false;
            }

            enabled = false;
        }
    }

    public State GetNextState()
    {
        foreach (var transition in _transisions)
        {
            if (transition.NeedTransit == true)
            {
                return transition.NextState;
            }
        }

        return null;
    }
}
