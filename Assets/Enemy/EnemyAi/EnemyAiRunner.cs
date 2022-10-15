using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiRunner : MonoBehaviour
{
    // something should set this
    public GameObject selfObject;
    public GameObject playerObject;

    public EnemyNav navigation;

    EnemyFollowState followState;
    EnemyAttackState attackState;
    IEnemyState currentState;

    

    // Update is called once per frame
    void Start()
    {
        // init states via builder
        followState = new EnemyFollowState();
        followState.nextState = attackState;

        attackState = new EnemyAttackState();
        attackState.nextState = followState;
        
        currentState = followState;
    }

    void FixedUpdate()
    {
        currentState.Behave();
        if(currentState.InChangeRange())
        {
            currentState = currentState.nextState;
        }
    }
}
