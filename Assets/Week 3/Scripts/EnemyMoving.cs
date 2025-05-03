using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : SaiBehaviour
{
    [SerializeField] protected Point pointToGo;
    [SerializeField] protected EnemyCtrl ctrl;
    //[SerializeField] protected bool isRun = false;
    //[SerializeField] protected bool isFast = false;
    [SerializeField] protected float targetDistance;
    [SerializeField] protected float runDistance = 20;
    [SerializeField] protected float fastDistance =10;

    [SerializeField] protected bool isRandomPath = false;
    [SerializeField] protected List<Point> allPoints;



    protected void LateUpdate()
    {
        this.MoveToTarget();
        this.UpdateAnimator();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
        this.LoadAllPoints();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.LogWarning(transform.name + ": LoadEnemyCtrl", gameObject);
    }

    protected virtual void MoveToTarget()
    {
        if (this.pointToGo == null) return;
        Vector3 postion = this.pointToGo.transform.position;
        this.targetDistance = Vector3.Distance(transform.position, this.pointToGo.transform.position);
        if (this.targetDistance <= this.fastDistance)
        {
            this.ctrl.Agent.speed = 6f; 

        }
        else if (targetDistance <= runDistance)
        {
            this.ctrl.Agent.speed = 3.5f;
        }
        else
        {
            this.ctrl.Agent.speed = 2f;
        }
        this.ctrl.Agent.SetDestination(postion);

    }

    protected virtual void UpdateAnimator()
    {
        if (this.targetDistance <= this.fastDistance)
        {
            this.ctrl.Animator.SetBool("IsRun", true);
            this.ctrl.Animator.SetBool("IsFast", true);
        }
        else if (targetDistance <= runDistance)
        {
            this.ctrl.Animator.SetBool("IsRun", true);
            this.ctrl.Animator.SetBool("IsFast", false);
        }
        else
        {
            this.ctrl.Animator.SetBool("IsRun", false);
            this.ctrl.Animator.SetBool("IsFast", false);
        }
    }
    protected virtual void UpdateNextPoint()
    {
        if (this.pointToGo == null) return;
        float distance = Vector3.Distance(transform.position, pointToGo.transform.position);
        if (distance < 0.5f)
        {
            if (isRandomPath)
            {
                Point next;
                do
                {
                    next = allPoints[Random.Range(0, allPoints.Count)];
                } while (next == pointToGo && allPoints.Count > 1);

                pointToGo = next;
            }
            else
            {
                pointToGo = pointToGo.NextPoint;
            }
        }
    }

    protected void FixedUpdate()
    {
        this.UpdateNextPoint();
    }
    protected virtual void LoadAllPoints()
    {
        if (this.allPoints != null && this.allPoints.Count > 0) return;

        this.allPoints = new List<Point>(FindObjectsOfType<Point>());
        Debug.LogWarning(transform.name + ": Loaded " + allPoints.Count + " points", gameObject);
    }
}
