using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState {
    public void Execute(PlayerController playerController) {
        if (playerController.fsm.isCanMove) {
            playerController.Move();
        }
        else {
            playerController.fsm.ChangeState(new AttackState());
        }
    }
}

