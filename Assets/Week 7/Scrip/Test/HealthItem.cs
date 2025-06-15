using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : BuffItem
{
    public int healthAmount = 20;

    public override void ApplyBuff(Player player)
    {
        player.Heal(healthAmount);
    }
}

