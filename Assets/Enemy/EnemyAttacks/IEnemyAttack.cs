using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyAttack
{
    GameObject proj {get; set;}
    Vector3 targetPosition {get; set;}
    void Use();
}

