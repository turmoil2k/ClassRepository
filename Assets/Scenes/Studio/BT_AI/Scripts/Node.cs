using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    public abstract void ActionNode(BTContext owner); //(Context owner);
}
