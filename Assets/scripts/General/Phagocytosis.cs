using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Phagocytosis : MonoBehaviour
{
    public string Tag;
    public LevelSystem levelsystem;
    public PlayerHealth GainHP;

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            levelsystem.GainExperienceFlatRate(20);
            GainHP.RestoreHealth(10);
        } 
    }
}
