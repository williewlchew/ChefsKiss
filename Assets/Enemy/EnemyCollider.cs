using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCollider : MonoBehaviour
{
    public EnemyManager enemyManager;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {        
            enemyManager.TakeDamage();
        }
    }
}
