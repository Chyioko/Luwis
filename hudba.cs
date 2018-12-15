using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudba : MonoBehaviour
{

    public GameObject otherObject;

    void OnMouseDown() // mouse click
    {
        if (otherObject != null && otherObject != null)
            otherObject.SetActive(!otherObject.activeSelf) ;
    }
}