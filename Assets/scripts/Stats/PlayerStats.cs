using UnityEngine;

public class PlayerStats : MonoBehaviour
{   
    public int maxHealth = 100;
    public int currentHealth { get; private set;}

    public Stat Damage;
    public Stat CellWall;

    void Awake ()
    {
        currentHealth = maxHealth;
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }
    public void TakeDamage (int Damage)
    {
        Damage -= CellWall.GetValue();
        Damage = Mathf.Clamp(Damage, 0, int.MaxValue);

        currentHealth -= Damage;
        Debug.Log(transform.name + " takes " + Damage + " damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log("U fucken ded");
    }

}

