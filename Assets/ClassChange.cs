using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassChange : MonoBehaviour
{
    [SerializeField] GameObject OldSelf;
    [SerializeField] GameObject class1, class2, class3, class4;

    public void ClassChange1()
    {
        OldSelf.SetActive(false);
        class1.SetActive(true);
    }

    public void ClassChange2()
    {
        OldSelf.SetActive(false);
        class2.SetActive(true);
    }

    public void ClassChange3()
    {
        class1.SetActive(false);
        class2.SetActive(false);
        class3.SetActive(true);
    }

    public void ClassChange4()
    {
        class1.SetActive(false);
        class2.SetActive(false);
        class4.SetActive(true);
    }

}
