using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState {
    public void Execute(PlayerController playerController) {
        if (playerController.fsm.isCanAttack) {
            playerController.Attack();
        }
        else {
            playerController.fsm.ChangeState(new MoveState());
        }
    }
}
