using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;
    int score = 0;

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GameObject.FindObjectOfType<PlayerScore>().IncrementScore();
        GetComponent<Animator>().SetTrigger("die");
    }
}
