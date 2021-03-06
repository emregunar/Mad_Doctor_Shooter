using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;

    private Enemy enemyScript;

    private void Awake()
    {
        enemyScript = GetComponent<Enemy>();
    }

    public void TakeDamage(float damageAmount)
    {
        if (health <= 0)
            return;

        health -= damageAmount;

        if(health <= 0f)
        {
            health = 0;

            //kill the enemy
            enemyScript.EnemyDied();
        }
    }


}
