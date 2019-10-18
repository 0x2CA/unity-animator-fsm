using System;
using UnityEngine;

public abstract class FSMStateMachineBehaviour<T> : StateMachineBehaviour where T : Enum {
    private T GetStateEnum (int hash) {
        string[] names = Enum.GetNames (typeof (T));
        for (int i = 0; i < names.Length; i++) {
            string name = names[i];
            if (Animator.StringToHash (name) == hash) {
                return (T) Enum.Parse (typeof (T), name);
            }
        }
        return default (T);
    }

    private string GetLayerString (Animator animator, int layer) {
        return animator.GetLayerName (layer);
    }

    override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        FSMController<T> fsm = animator.GetComponent<FSMController<T>> ();
        if (fsm != null) {
            fsm.OnStateEnter (GetLayerString (animator, layerIndex), GetStateEnum (stateInfo.shortNameHash));
        } else {
            Debug.LogWarning ("目标 " + animator.gameObject.name + " 无FSMController");
        }
    }

    override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        FSMController<T> fsm = animator.GetComponent<FSMController<T>> ();
        if (fsm != null) {
            fsm.OnStateUpdate (GetLayerString (animator, layerIndex), GetStateEnum (stateInfo.shortNameHash));
        } else {
            Debug.LogWarning ("目标 " + animator.gameObject.name + " 无FSMController");
        }
    }

    override public void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        FSMController<T> fsm = animator.GetComponent<FSMController<T>> ();
        if (fsm != null) {
            fsm.OnStateExit (GetLayerString (animator, layerIndex), GetStateEnum (stateInfo.shortNameHash));
        } else {
            Debug.LogWarning ("目标 " + animator.gameObject.name + " 无FSMController");
        }
    }

    override public void OnStateMove (Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        FSMController<T> fsm = animator.GetComponent<FSMController<T>> ();
        if (fsm != null) {
            fsm.OnStateMove (GetLayerString (animator, layerIndex), GetStateEnum (stateInfo.shortNameHash));
        } else {
            Debug.LogWarning ("目标 " + animator.gameObject.name + " 无FSMController");
        }
    }

    override public void OnStateIK (Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        FSMController<T> fsm = animator.GetComponent<FSMController<T>> ();
        if (fsm != null) {
            fsm.OnStateIK (GetLayerString (animator, layerIndex), GetStateEnum (stateInfo.shortNameHash));
        } else {
            Debug.LogWarning ("目标 " + animator.gameObject.name + " 无FSMController");
        }
    }

}