using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateScript2 : MonoBehaviour
{
    //GameObject floorObject; 1
    //===
    public GameObject DDfloorObj; // 2

    void Start()
    {
        //floorObject = GameObject.Find("Floor"); 1
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.name == "IAMTHEENEMY")
        {
            //floorObject.AddComponent<Rigidbody>(); 1
            gameObject.AddComponent<Rigidbody>();
            //=======
            DDfloorObj.AddComponent<Rigidbody>(); // 2
        }
    }
}
