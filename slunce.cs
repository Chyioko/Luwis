﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slunce : MonoBehaviour {

    public Light svetlo;
	void Start () {

        svetlo = GetComponent<Light>();
	}
	
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, 0.5f * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }

    }

