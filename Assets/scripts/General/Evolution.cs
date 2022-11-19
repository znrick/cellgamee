using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Evolution : MonoBehaviour
{
    public LevelSystem levelsystem;
    [SerializeField] GameObject PEvolution;
    // Update is called once per frame
    void Update()
    {
        if (levelsystem.level == 10)
        {
            PEvolution.SetActive(true);
        }
    }

    public void BacteriaEvol()
    {
        SceneManager.LoadScene("Level 2 (Bacteria)");
    }
    public void ArchaeaEvol()
    {
        SceneManager.LoadScene("Level 2 (Archaea)");
    }
}
