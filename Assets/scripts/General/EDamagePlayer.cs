using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDamagePlayer : MonoBehaviour
{
    public float damage;
    public PlayerHealth playerHealth;
    //[SerializeField] private float knockback;

    private void OnCollisionStay2D (Collision2D bruh)
    {
        if(bruh.gameObject.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage(damage);
            /*Rigidbody2D Enemy = bruh.collider.GetComponent<Rigidbody2D>();
                if (Enemy != null)
                {
                    StartCoroutine(KnockCoroutine(Enemy));
                }*/
        }
    }
    /*private IEnumerator KnockCoroutine(Rigidbody2D Enemy)
        {
        Vector2 forceDirection = Enemy.transform.position - transform.position;
        Vector2 force = forceDirection.normalized * knockback;

        Enemy.velocity = force;
        yield return new WaitForSeconds(.3f);

        Enemy.velocity = new Vector2();
        }*/
}