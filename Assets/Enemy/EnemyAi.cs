using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private Transform target;

    // something should set this
    public EnemyNav navigation;

    // Update is called once per frame
    void Update()
    {
        navigation.goal = target;
    }

    public void SetTarget(Transform targetInput)
    {
        target = targetInput;
    }
}
