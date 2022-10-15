using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    IEnemyState nextState {get; set;}
    float changeRange { set;}
    bool InChangeRange();
    void Behave();
}
