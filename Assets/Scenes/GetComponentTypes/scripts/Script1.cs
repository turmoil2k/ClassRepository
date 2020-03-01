using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    Rigidbody myRB; // THIS/MY rb
    //============
    Rigidbody enemyRB; //access rb
    //============
    Enemyscript enemyScript; //access script / variable
    
    public bool disableGravity = false;
    public bool fly = false;
    public bool rotate = false;
    public bool constraints = false;
    public bool enemyDialogue = false;
    public bool defaultpos = false;
    public bool surprise = false;

    //==============================
    //GameObject enemyObject; //access object
    //============================

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        //=======================
        enemyScript = GameObject.Find("IAMTHEENEMY").GetComponent<Enemyscript>();

        enemyRB = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody>();
        //========================



        /*
        enemyObject = GameObject.FindWithTag("Enemy");
        enemyObject.GetComponent<Rigidbody>();
        enemyObject.GetComponent<Enemyscript>();
        */
    }

    void Update()
    {
        if (disableGravity == true)
        {
            enemyRB.useGravity = false;
        }
        else
        {
            enemyRB.useGravity = true;
        }

        if (fly == true)
        {
            enemyRB.velocity = transform.up * 10;
        }

        if (rotate == true)
        {
            enemyRB.transform.Rotate(3f, 3f, 3f);
        }
        else
        {
            enemyRB.transform.Rotate(0f, 0f, 0f);
        }

        if (constraints == true)
        {
            enemyRB.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            enemyRB.constraints = RigidbodyConstraints.None;
        }

        if (enemyDialogue == true)
        {
            enemyScript.enemyTalk = true;
        }
        else
        {
            enemyScript.enemyTalk = false;
        }

        if (defaultpos == true)
        {
            enemyRB.position = new Vector3(-13f, 1.5f, -9f);
        }

        if (surprise == true)
        {
            enemyRB.transform.position += new Vector3(0f, 0f, 1f * Time.deltaTime);
        }
    }
}
