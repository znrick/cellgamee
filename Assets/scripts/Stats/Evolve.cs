using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolve : MonoBehaviour
{
    [SerializeField] GameObject Evolve1, Evolve2;
    PauseManager pausemanager;

    void Awake()
    {
        pausemanager = GetComponent<PauseManager>();
    }

    public void OpenFirstEvolve()
    {
        pausemanager.Pause();
        Evolve1.SetActive(true);
    }

    public void OpenSecondEvolve()
    {
        pausemanager.Pause();
        Evolve2.SetActive(true);
    }

    public void CloseFirstEvolve()
    {
        pausemanager.UnPause();
        Evolve1.SetActive(false);
    }   

    public void CloseSecondEvolve()
    {
        pausemanager.UnPause();
        Evolve2.SetActive(false);
    }
}
