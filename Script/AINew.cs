using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MY_FSM;
using System;
using Random = UnityEngine.Random;

[Serializable]
public class ZombieBlackboard : Blackboard
{
    public float idleTime;
    public float moveSpeed;
    public Transform transform;

    public Vector2 targetPos;

}

public class AI_IdleState : IState
{
    private float idleTimer;
    private FSM fsm;
    private ZombieBlackboard blackboard;
    public AI_IdleState(FSM fsm)
    {
        this.fsm = fsm;
        this.blackboard = fsm.blackboard as ZombieBlackboard;
    }
    public void OnEnter()
    {
        idleTimer = 0;
    }

    public void OnExit()
    {
    }

    public void OnUpdate()
    {
        idleTimer += Time.deltaTime;
        if (idleTimer > blackboard.idleTime)
        {
            this.fsm.SwitchState(StateType.MOVE);
        }
    }
}

public class AI_MoveState : IState
{
    private FSM fsm;
    private ZombieBlackboard blackboard;
    public AI_MoveState(FSM fsm)
    {
        this.fsm = fsm;
        this.blackboard = fsm.blackboard as ZombieBlackboard;
    }
    public void OnEnter()
    {
        float randomX = Random.Range(-10, 10);
        float randomY = Random.Range(-10, 10);
        // 当前位置从黑板里拿
        blackboard.targetPos = new Vector2(blackboard.transform.position.x + randomX, blackboard.transform.position.y);
    }

    public void OnExit()
    {
    }

    public void OnUpdate()
    {
        if (Vector2.Distance(blackboard.transform.position, blackboard.targetPos) < 0.1f)
        {
            fsm.SwitchState(StateType.Idle);
        }
        else
        {
            blackboard.transform.position = Vector2.MoveTowards(blackboard.transform.position, blackboard.targetPos, blackboard.moveSpeed * Time.deltaTime);
        }
    }
}

public class AINew : MonoBehaviour
{
    // Start is called before the first frame update
    private FSM fsm;
    public ZombieBlackboard blackboard;
    void Start()
    {
        fsm = new FSM(blackboard);
        fsm.AddState(StateType.Idle, new AI_IdleState(fsm));
        fsm.AddState(StateType.MOVE, new AI_MoveState(fsm));
        fsm.SwitchState(StateType.Idle);
    }

    // Update is called once per frame
    void Update()
    {
        fsm.OnCheck();
        fsm.OnUpdate();
        Flip();
    }

    void Flip()
    {
        if (blackboard.targetPos != Vector2.zero)
        {
            if (blackboard.targetPos.x > transform.position.x)
            {
                transform.localScale = new Vector2(-1, 1);
            }
            else
            {
                transform.localScale = new Vector2(1, 1);
            }
        }
    }

    private void FixedUpdate()
    {
        fsm.OnFixUpdate();
    }
}
