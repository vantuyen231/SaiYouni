using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] protected Transform targetToMove;
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Animator animator;
    //[SerializeField] protected bool isRun = false;
    //[SerializeField] protected bool isFast = false;
    [SerializeField] protected float targetDistance;
    [SerializeField] protected float runDistance = 20;
    [SerializeField] protected float fastDistance =10;



    protected void Start()
    {

    }

    protected void FixedUpdate()
    {
        this.MoveToTarget();
        this.UpdateAnimator();
    }

    protected virtual void MoveToTarget()
    {
        Vector3 postion = this.targetToMove.position;
        this.targetDistance = Vector3.Distance(transform.position, this.targetToMove.position);
        if (this.targetDistance <= this.fastDistance)
        {
            agent.speed = 6f; 
            animator.SetBool("IsRun", true);
            animator.SetBool("IsFast", true);
        }

        else if (targetDistance <= runDistance)
        {
            agent.speed = 3.5f; 
            animator.SetBool("IsRun", true);
            animator.SetBool("IsFast", false);
        }
        else
        {
            agent.speed = 2f;
            animator.SetBool("IsRun", false);
            animator.SetBool("IsFast", false);
        }
        this.agent.SetDestination(postion);

    }

    protected virtual void UpdateAnimator()
    {

    }
}
