using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : MonoBehaviour, IEnemyState
{
    private float _changeRange;
    public float changeRange{
        set => _changeRange = value;
    }
    

    private IEnemyState _nextState;
    public IEnemyState nextState{
        get => _nextState;
        set => _nextState = value;
    }

    // needs enemyattack, playerobject
    void Start()
    {
        
    }
    
    public bool InChangeRange()
    {
        // get distance of self and player
        return false;
    }

    // Update is called once per frame
    public void Behave()
    {

        //navigation.goal = playerObject.transform;
    }
}
