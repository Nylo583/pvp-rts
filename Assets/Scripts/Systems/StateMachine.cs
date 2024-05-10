using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    protected State _state;

    protected bool inTransition = false;
    protected bool inExecution = false;
    public IEnumerator SetState(State state) {
        inTransition = true;
        yield return StartCoroutine(_state.Exit());
        _state = state;
        yield return StartCoroutine(_state.Enter());
        inTransition = false;
    }

    public IEnumerator ExecuteState() {
        inExecution = true;
        yield return StartCoroutine(_state.Execute());
        inExecution = false;
    }

    public State GetState() { return _state; }

    private void Update() {
        if (!inExecution && !inTransition) {
            StartCoroutine(ExecuteState());
        }
    }
}
