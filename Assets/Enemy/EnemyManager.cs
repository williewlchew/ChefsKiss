using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    void Start()
    {

    }

    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
