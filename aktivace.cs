using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aktivace : MonoBehaviour
{

    public GameObject otherObject;

    void Update() {

        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            objevit();
        }
    }
    void objevit() {
          if (otherObject != null && otherObject != null)
              otherObject.SetActive(!otherObject.activeSelf);
      }
}
