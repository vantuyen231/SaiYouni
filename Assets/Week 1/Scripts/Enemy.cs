using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables
    public GameObject Player ;
    //variables 1 
    public float maxHp;
    public float minHp;
    //variables 2
    [SerializeField] private float currentHp;
    //variables 3 
    [SerializeField] private int damegeEnemy;
    //variables 4 
    [SerializeField] private float speed;
    //variables 5 
    [SerializeField] private bool isDead;

    public int health = 0;

    // 5 Enemies methods

    private void Start()
    {
        RandomHp();
    }
    public void RandomHp()
    {
        this.health = UnityEngine.Random.Range(0, 100);
    }
    
    //Method 1
    private void Move()
    {
        Debug.Log("Move");
        return;
    }
    //Method 2
    private void TakeDamage()
    {
        Debug.Log("TakeDamage");
        return; 
    }

    //Method 3
    private void Die()
    {
        if (isDead)
        {
            Debug.Log("Dead");
            return;
        }
        Debug.Log("Alive");
    }

    //Method 4
    private void Attack(Player player)
    {
        return;
    }

    //Method 5
    private void Patrol()
    {
        return;
    }

}
