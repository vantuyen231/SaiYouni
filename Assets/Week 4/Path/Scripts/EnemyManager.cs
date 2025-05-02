using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : SaiBehaviour
{
    public EnemyCtrl minEnemy;
    public EnemyCtrl maxEnemy;
    public List<EnemyCtrl> enemies;

    protected override void Start()
    {

    }

    protected override void LoadComponents()
    {
        //base.LoadComponents();
        this.LoadEnemeies();
    }

    protected virtual void LoadEnemeies()
    {
        if (this.enemies.Count > 0) return;
        EnemyCtrl enemyCtrl;
        foreach (Transform child in transform)
        {
            enemyCtrl = child.GetComponent<EnemyCtrl>();
            this.enemies.Add(enemyCtrl);
        }
        Debug.LogWarning(transform.name + ": LoadEnemeies", gameObject);
    }
}