using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{

    Stack<CurrentState> menus = new Stack<CurrentState>();
    public CurrentState firstMenu;
    

    void Start()
    {
        menus.Push(firstMenu);
        menus.Peek().SA_True();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            menus.Peek().SA_False();

            menus.Peek().SA_True();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            menus.Peek().SA_False();
            //
            menus.Peek().SA_True();
        }
    }

    public void NewState(CurrentState incomingState)
    {

    }


}
