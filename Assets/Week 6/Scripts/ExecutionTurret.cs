using UnityEngine;
using System.Collections.Generic;

public class ExecutionTurret : SaiBehaviour
{
    [SerializeField] private TurretCtrl ctrl;
    [SerializeField] private float damageAmount = 100f;
    [SerializeField] private float hpThreshold = 0.3f; 

    protected override void Start()
    {
        base.Start();
        InvokeRepeating(nameof(Execute), 0f, 1f);
    }

    private void Execute()
    {
        List<Targetable> enemies = ctrl.TurretTargeting.Enemies;
        foreach (Targetable enemy in enemies)
        {
            DamageReceiver receiver = enemy.GetComponent<DamageReceiver>();
            if (receiver != null && receiver.IsAlive())
            {
                float hpPercent = (float)receiver.CurrentHp / receiver.MaxHp;
                if (hpPercent < hpThreshold)
                {
                    receiver.Deduct((int)damageAmount);
                    receiver.IsHit();
                }
            }
        }
    }
}
