using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAOE : SaiBehaviour
{
    [SerializeField] protected TurretCtrl ctrl;
    [SerializeField] protected float damage = 50f;
    [SerializeField] protected float shootCooldown = 1.5f;

    protected override void Start()
    {
        base.Start();
        InvokeRepeating(nameof(DealAOEDamage), 0f, shootCooldown);
    }

    protected virtual void DealAOEDamage()
    {
        List<Targetable> enemies = this.ctrl.TurretTargeting.Enemies;
        if (enemies == null || enemies.Count == 0) return;

        foreach (Targetable enemy in enemies)
        {
            if (enemy == null) continue;
            //enemy.ApplyDamage((int)damage);
        }

        // (Optional) 
        // Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
    }
}
