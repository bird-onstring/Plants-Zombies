using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MY_FSM;


// 闲逛、索敌、攻击、死亡、胜利
// public enum StateType
// {
//     Idle,
//     Find_Enemy,
//     Attack,
//     Die,
//     Success,
// }

public class AI : MonoBehaviour
{
    // 当前所处的状态
    private StateType curState;
    void Start()
    {
        curState = StateType.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        switch (curState)
        {
            case StateType.Idle:
                {
                    OnIdle();
                    break;
                }
            case StateType.Find_Enemy:
                {
                    OnFindEnemy();
                    break;
                }
            case StateType.Attack:
                {
                    OnAttack();
                    break;
                }
            case StateType.Die:
                {
                    OnDie();
                    break;
                }
            case StateType.Success:
                {
                    OnSuccess();
                    break;
                }
            default:
                break;
        }
    }

    // 不同状态时的响应函数
    void OnIdle() { }
    void OnFindEnemy() { }
    void OnAttack() { }
    void OnDie() { }
    void OnSuccess() { }

}
