using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItem : BuffItem
{
    public int damageBoost = 5;
    public float duration = 5f;

    public override void ApplyBuff(Player player)
    {
        player.ApplyDamageBoost(damageBoost, duration);
    }
}

