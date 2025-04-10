using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected NavMeshAgent agent;


    protected void Start()
    {

    }

    protected void FixedUpdate()
    {
        this.MoveToTarget();
    }

    protected virtual void MoveToTarget()
    {
        Vector3 postion = this.target.position;
        this.agent.SetDestination(postion);

    }
}
