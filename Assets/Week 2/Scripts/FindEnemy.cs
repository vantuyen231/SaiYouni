using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : SaiBehavior
{
    //----------------------Edit below here --------------------
    public List<Enemy> enemyList;

    private void Start()
    {
        this.ShowEnemey();
        
    }
    protected override void LoadComponents()
    {

        this.LoadEnemeies();
    }

    protected virtual void LoadEnemeies()
    {
        if (this.enemyList.Count > 0) return;
        Enemy enemyHP;
        foreach (Transform child in transform)
        {
            enemyHP = child.GetComponent<Enemy>();
            this.enemyList.Add(enemyHP);
        }
        Debug.LogWarning(transform.name + ": LoadEnemeies", gameObject);
    }

    void ShowEnemey()
    {
        foreach (Enemy enemyHP in this.enemyList)
        {
            Debug.Log(enemyHP.name + ": " + enemyHP.health);
        }
    }

    public Enemy FindEnemyWithSmallestHealth()
    {
        if (enemyList == null || enemyList.Count == 0) return null; 

        Enemy weakestEnemy = enemyList[0]; 
        foreach (Enemy enemy in enemyList)
        {
            if (enemy.health < weakestEnemy.health) 
            {
                weakestEnemy = enemy;
            }
        }
        return weakestEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        return null;
    }

    //----------------------Edit above here --------------------
}
