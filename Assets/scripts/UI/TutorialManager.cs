using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject FoodSpawner;
    //public GameObject EnemySpawner;
    public float waitTime = 2f;
    public LevelSystem levelsystem;
    public Button STButton;

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            STButton.enabled = false;
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 1)
        {
            FoodSpawner.SetActive(true);

            if (levelsystem.level == 2)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            if (levelsystem.level == 5){
                popUpIndex++;
                STButton.enabled = true;
            }
        }
        else if (popUpIndex == 3)
        {
            if (levelsystem.level == 9)
            {
                popUpIndex++;
            }
        }
        /*else if (popUpIndex == 4)
        {
            if (levelsystem.level == 10)
            {}
        }*/
    }
     
}
