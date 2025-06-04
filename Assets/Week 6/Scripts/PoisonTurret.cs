using UnityEngine;

public class PoisonTargeting : TurretTargeting
{
    [SerializeField] protected float damagePerSecond = 2f;

    protected override void OnTriggerStay(Collider other)
    {
        DamageReceiver receiver = other.GetComponent<DamageReceiver>();
        if (receiver != null && receiver.IsAlive())
        {
            receiver.Deduct((int)(damagePerSecond * Time.deltaTime));
            receiver.IsHit(); 
        }
    }
}