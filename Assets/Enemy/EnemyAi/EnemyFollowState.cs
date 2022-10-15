using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowState : MonoBehaviour, IEnemyState
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

    public GameObject selfObject;
    public GameObject playerObject;
    public EnemyNav navigation;
    
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
