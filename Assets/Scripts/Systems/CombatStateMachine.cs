using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatStateMachine : StateMachine {
    [HideInInspector]
    public State draftState;

    [HideInInspector]
    public State attackState;

    [HideInInspector]
    public State enhanceState;
}