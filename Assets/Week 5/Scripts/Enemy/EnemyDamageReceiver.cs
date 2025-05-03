using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [Header("Enemy")]
    [SerializeField] protected EnemyCtrl ctrl;

    protected virtual void LateUpdate()
    {
        this.UpdateDeadAnimation();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.LogWarning(transform.name + ": LoadEnemyCtrl", gameObject);
    }

    protected virtual void UpdateDeadAnimation()
    {
        this.ctrl.Animator.SetBool("IsAlive", this.isAlive);
    }
    public override void IsHit()
    {
        this.ctrl.Animator.SetTrigger("IsHit");
    }
}