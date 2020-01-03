using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public IState currentState { get; private set; }
    public bool isCanAttack;
    public bool isCanMove;
    public PlayerController playerController;
    void Start() {

    }

    public void ChangeState(IState newState) {
        currentState = newState;
    }

    void Update() {
        if (currentState != null && playerController != null) {
            currentState.Execute(playerController);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            isCanAttack = true;
            isCanMove = false;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            isCanAttack = false;
            isCanMove = true;
        }
    }
}
