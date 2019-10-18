using System;
using UnityEngine;

[RequireComponent (typeof (Animator))]
public abstract class FSMController<T> : MonoBehaviour where T : Enum {

    /// <summary>
    /// 动画状态机FSM层
    /// </summary>
    public string currentLayer = "FSM Layer";

    public T currentState;

    public void OnStateEnter (string layer, T state) {
        if (layer == currentLayer) {
            currentState = state;
            OnStateEnter (state);
        }
    }

    public void OnStateUpdate (string layer, T state) {
        if (layer == currentLayer) {
            OnStateUpdate (state);
        }
    }
    public void OnStateExit (string layer, T state) {
        if (layer == currentLayer) {
            OnStateExit (state);
        }
    }

    public void OnStateMove (string layer, T state) {
        if (layer == currentLayer) {
            OnStateMove (state);
        }
    }

    public void OnStateIK (string layer, T state) {
        if (layer == currentLayer) {
            OnStateIK (state);
        }
    }

    public abstract void OnStateEnter (T state);

    public abstract void OnStateUpdate (T state);

    public abstract void OnStateExit (T state);

    public abstract void OnStateMove (T state);

    public abstract void OnStateIK (T state);
}