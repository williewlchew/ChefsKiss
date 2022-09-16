using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCollider : MonoBehaviour
{
    public EnemyManager enemyManager;

    void OnTriggerEnter(Collider collider)
    {
        enemyManager.TakeDamage();
    }
}
