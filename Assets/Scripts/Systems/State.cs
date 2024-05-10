using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public StateMachine parentSM;

    public abstract IEnumerator Enter();
    public abstract IEnumerator Execute();
    public abstract IEnumerator Exit();
}
