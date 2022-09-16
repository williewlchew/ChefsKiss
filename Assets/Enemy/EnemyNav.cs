using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNav : MonoBehaviour
{
    public Transform goal;

    private UnityEngine.AI.NavMeshAgent agent;

    void Start() {
        
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    
    void Update () {
        //tell an agent to start calculating a path
        agent.destination = goal.position; 
    }
}
