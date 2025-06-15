using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    public PlayerBuffType buffType;
    public float buffValue = 1.5f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().ApplyBuff(buffType, buffValue, duration);
            Destroy(gameObject);
        }
    }
}
