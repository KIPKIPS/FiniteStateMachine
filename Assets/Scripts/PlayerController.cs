using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public FSM fsm;

    void Start() {
        fsm = GetComponent<FSM>();
        fsm.playerController = this;
        //初始化一个默认状态机
        fsm.ChangeState(new MoveState());
    }
    public void Move() {
        Debug.Log("move");
    }

    public void Attack() {
        Debug.Log("attack");
    }
}
