using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : SaiBehavior
{
    //----------------------Edit below here --------------------
    public Enemy minEnemy;
    public Enemy maxEnemy;
    public List<Enemy> enemyList;


    private void Start()
    {
        this.LoadComponents();
        this.ShowEnemey();
        FindEnemyWithSmallestHealth();
        FindEnemyWithLargestHealth();

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
        float minHealth = Mathf.Infinity;

        foreach (Enemy enemy in this.enemyList)
        {
            if (enemy.health < minHealth)
            {
                minHealth = enemy.health;
                this.minEnemy = enemy;
            }
        }

        if (minEnemy != null)
        {
            Debug.Log("Min Enemy: " + this.minEnemy.name + " - " + this.minEnemy.health);
        }

        return minEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        float maxHealth = Mathf.NegativeInfinity;

        foreach (Enemy enemy in this.enemyList)
        {
            if (enemy.health > maxHealth)
            {
                maxHealth = enemy.health;
                this.maxEnemy = enemy;
            }
        }

        if (maxEnemy != null)
        {
            Debug.Log("Max Enemy: " + this.maxEnemy.name + " - " + this.maxEnemy.health);
        }

        return maxEnemy;

        //----------------------Edit above here --------------------
    }
}