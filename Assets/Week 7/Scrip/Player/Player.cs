using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float baseSpeed = 5f;
    public int baseDamage = 10;

    private float currentSpeed;
    private int currentDamage;

    private void Start()
    {
        currentHealth = maxHealth;
        currentSpeed = baseSpeed;
        currentDamage = baseDamage;
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        Debug.Log("Da hoi mau: " + amount);
    }

    public void ApplySpeedBoost(float amount, float duration)
    {
        StopCoroutine("SpeedBuff");
        StartCoroutine(SpeedBuff(amount, duration));
    }

    private IEnumerator SpeedBuff(float amount, float duration)
    {
        currentSpeed = baseSpeed + amount;
        yield return new WaitForSeconds(duration);
        currentSpeed = baseSpeed;
    }

    public void ApplyDamageBoost(int amount, float duration)
    {
        StopCoroutine("DamageBuff");
        StartCoroutine(DamageBuff(amount, duration));
    }

    private IEnumerator DamageBuff(int amount, float duration)
    {
        currentDamage = baseDamage + amount;
        yield return new WaitForSeconds(duration);
        currentDamage = baseDamage;
    }
}
