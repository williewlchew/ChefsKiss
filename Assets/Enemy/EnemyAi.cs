using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    // something should set this
    public GameObject playerObject;

    public EnemyNav navigation;

    

    // Update is called once per frame
    void Update()
    {
        navigation.goal = playerObject.transform;
    }
}
