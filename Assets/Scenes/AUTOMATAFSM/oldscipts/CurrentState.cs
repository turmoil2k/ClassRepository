using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour
{
    public GameObject currentMenu;
    public GameObject nextMenu;


    public void Awake()
    {
        SA_False();
    }

    public void Update()
    {

    }

    public void SA_True()
    {
        gameObject.SetActive(true);
    }

    public void SA_False()
    {
        gameObject.SetActive(false);
    }
}
