using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    State currentstate;
    void Start()
    {
        currentstate = GetComponent<Roaming>();
    }
    void Update()
    {
        currentstate.Action(this);
    }
    public void Switch(State newState)
    {
        currentstate = newState;
    }
}
