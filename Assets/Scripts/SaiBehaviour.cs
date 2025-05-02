using UnityEngine;

public class SaiBehaviour : MonoBehaviour
{
    protected virtual void Start()
    {

    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        //TODO: for override
    }
    public virtual void SetActive(bool status)
    {
        gameObject.SetActive(status);
    }

    protected virtual void ResetValue()
    {
        //For override
    }
}