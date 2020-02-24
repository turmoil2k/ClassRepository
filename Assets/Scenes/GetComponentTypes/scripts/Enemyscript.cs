using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public bool enemyTalk = false;

    void Update()
    {
        if (enemyTalk == true)
        {
            print("Mr Stark I dont feel so good...");
        }
    }
}
