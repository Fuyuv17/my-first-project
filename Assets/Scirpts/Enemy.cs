using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rb.GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("die", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }

}
