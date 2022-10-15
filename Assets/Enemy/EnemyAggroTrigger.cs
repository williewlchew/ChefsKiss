using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggroTrigger : MonoBehaviour
{
    public Transform restPosition;
    public EnemyAi _enemyAi;

    void Start()
    {
        _enemyAi.SetTarget(restPosition);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {     
            _enemyAi.SetTarget(other.gameObject.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {    
            _enemyAi.SetTarget(restPosition);
        }
    }
}
