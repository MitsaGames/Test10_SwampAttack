using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private State _firstState;
    [SerializeField] private Player _target;

    private Enemy _enemy;
    private State _currentState;

    public State CurrentState => _currentState;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();

        ResetState();
    }

    private void Update()
    {
        if (_currentState == null) 
        {
            return;
        }

        var nextState = _currentState.GetNextState();

        if(nextState != null)
        {
            Transit(nextState);
        }
    }

    private void ResetState()
    {
        _currentState = _firstState;

        if (_currentState != null)
        {
            _currentState.Enter(_target);
        }
    }

    private void Transit(State nextState)
    {
        if(_currentState != null)
        {
            _currentState.Exit();
        }

        _currentState = nextState;

        if(_currentState != null)
        {
            _currentState.Enter(_target);
        }
    }
}
