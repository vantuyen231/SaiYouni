using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : BuffItem
{
    public float speedBoost = 2f;
    public float duration = 5f;

    public override void ApplyBuff(Player player)
    {
        player.ApplySpeedBoost(speedBoost, duration);
    }
}
