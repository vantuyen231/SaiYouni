using UnityEngine;

public abstract class BuffItem : MonoBehaviour
{
    public abstract void ApplyBuff(Player player);

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            ApplyBuff(player);
            Destroy(gameObject); 
        }
    }
}
