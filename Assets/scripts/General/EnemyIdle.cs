using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdle : MonoBehaviour
{
    public GameObject Food;
    public float speed;
    public float distanceBetween;
    
    private float distance;
   
    void Update()
    {
        Food = GameObject.FindWithTag("Food");
        distance = Vector2.Distance(transform.position, Food.transform.position);
        Vector2 direction = Food.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Food.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
        } 
    }
}