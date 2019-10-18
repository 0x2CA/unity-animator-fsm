using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FSMState {
    Run,
    Idel
}

public class Test : FSMController<FSMState> {
    public Transform plane;
    public Transform cube;

    public override void OnStateEnter (FSMState state) {
        print ("OnStateEnter" + state);

    }

    public override void OnStateExit (FSMState state) { }

    public override void OnStateIK (FSMState state) { }

    public override void OnStateMove (FSMState state) { }

    public override void OnStateUpdate (FSMState state) { }

    private void Update () {
        float sub = (cube.position.z - plane.position.z);
        // print ("lenght" + sub);

        GetComponent<Animator> ().SetFloat ("lenght", sub);

        if (currentState == FSMState.Idel) {
            cube.position += new Vector3 (0, 0, 1 * Time.deltaTime);
        } else if (currentState == FSMState.Run) {
            cube.position -= new Vector3 (0, 0, 1 * Time.deltaTime);

        }
    }

}