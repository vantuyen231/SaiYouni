using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : SaiBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Animator animator;


    public NavMeshAgent Agent => agent;
    public Animator Animator => animator;

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
        if (this.agent != null) return;
        this.agent = GetComponent<NavMeshAgent>();
        Debug.LogWarning(transform.name + ": LoadAgent", gameObject);
    }

    protected virtual void LoadAnimator()
    {
        if (this.animator != null) return;
        this.animator = transform.Find("Model").GetComponent<Animator>();
        Debug.LogWarning(transform.name + ": LoadAnimator", gameObject);
    }
}
