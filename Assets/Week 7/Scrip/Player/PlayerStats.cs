using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float baseDamage = 10f;
    public float baseSpeed = 5f;
    public bool trapResistant = false;

    private float damageMultiplier = 1f;
    private float speedMultiplier = 1f;

    public void ApplyBuff(PlayerBuffType type, float value, float duration)
    {
        StartCoroutine(HandleBuff(type, value, duration));
    }

    private IEnumerator HandleBuff(PlayerBuffType type, float value, float duration)
    {
        switch (type)
        {
            case PlayerBuffType.DamageUp:
                damageMultiplier *= value;
                break;
            case PlayerBuffType.SpeedBoost:
                speedMultiplier *= value;
                break;
            case PlayerBuffType.TrapResist:
                trapResistant = true;
                break;
        }

        yield return new WaitForSeconds(duration);

        // Reset
        switch (type)
        {
            case PlayerBuffType.DamageUp:
                damageMultiplier /= value;
                break;
            case PlayerBuffType.SpeedBoost:
                speedMultiplier /= value;
                break;
            case PlayerBuffType.TrapResist:
                trapResistant = false;
                break;
        }
    }

    public float GetCurrentDamage() => baseDamage * damageMultiplier;
    public float GetCurrentSpeed() => baseSpeed * speedMultiplier;
}
