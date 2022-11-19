using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverEvolve : MonoBehaviour
{
    public Text EvolDesc;

    public void UnHover()
    {
        EvolDesc.enabled = false;
    }

    public void HoverEvol1()
    {
        EvolDesc.enabled = true;
        EvolDesc.GetComponent<Text>().text = "testing cuh";
    }
    public void HoverEvol2()
    {
        EvolDesc.enabled = true;
        EvolDesc.GetComponent<Text>().text = "testing cuh";
    }
    public void HoverEvol3()
    {
        EvolDesc.enabled = true;
        EvolDesc.GetComponent<Text>().text = "testing cuh";
    }
    public void HoverEvol4()
    {
        EvolDesc.enabled = true;
        EvolDesc.GetComponent<Text>().text = "testing cuh";
    }
}