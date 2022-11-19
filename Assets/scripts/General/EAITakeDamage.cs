using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EAITakeDamage : MonoBehaviour
{
    [SerializeField]public float maxHealth = 50;
    public float currentHealth;
    //private float knockback = 5;

    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float dmgAmount)
    {
        currentHealth -= dmgAmount;
    }
    public void RestoreHealth(float healAmount)
    {
        currentHealth += healAmount;
    }


    private void OnCollisionStay2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            TakeDamage(10);
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
            /*Rigidbody2D Player = collision.collider.GetComponent<Rigidbody2D>();
                if (Player != null)
                {
                    StartCoroutine(KnockCoroutine(Player));
                }*/
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            RestoreHealth(10);
        } 
    }


   /* private IEnumerator KnockCoroutine(Rigidbody2D Player)
    {
        Vector2 forceDirection = Player.transform.position - transform.position;
        Vector2 force = forceDirection.normalized * knockback;

        Player.velocity = force;
        yield return new WaitForSeconds(.3f);

        Player.velocity = new Vector2();
    }*/
}
