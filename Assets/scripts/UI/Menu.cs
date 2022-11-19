using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    PauseManager pausemanager;

    void Awake()
    {
        pausemanager = GetComponent<PauseManager>();
    }
    
    public void Pause()
    {
        menu.SetActive(true);
        pausemanager.Pause();
    }
    
    public void Resume()
    {
        menu.SetActive(false);
        pausemanager.UnPause();
    }

    public void MainMenu(int SceneID)
    {
        pausemanager.UnPause();
        SceneManager.LoadScene(SceneID);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void ReturnMM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
