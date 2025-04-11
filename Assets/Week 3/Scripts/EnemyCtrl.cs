using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : SaiBehavior
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Animator animator;

    protected override void Awake()
    {
        base.Awake();

    }

    protected override void LoadComponents()
    {
        base .LoadComponents();
        this.LoadAgent();
    }
    
    protected virtual void LoadAgent()
    {

    }
}
