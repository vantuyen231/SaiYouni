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
        this.LoadAnimator();
    }
    
    protected virtual void LoadAgent()
    {
        if(this.agent != null) return;
        this.agent = transform.Find("Model").GetComponent<NavMeshAgent>();

        Debug.LogWarning(transform.name +": LoadAgent", gameObject);
    }

    protected virtual void LoadAnimator()
    {
        if (this.animator != null) return;
        this.animator = GetComponent<Animator>();

        Debug.LogWarning(transform.name + ": LoadAnimator", gameObject);
    }
}
