using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootAttack : MonoBehaviour, IEnemyAttack
{
    private GameObject _proj;
    private Vector3 _target;

    public GameObject proj{
        get => _proj;
        set => _proj = value;
    }

    public Vector3 targetPosition{
        get => _target;
        set => _target = value;
    }

    public void Use()
    {
        Instantiate(_proj, _target, Quaternion.Euler(0, 0, 0));
    }
}