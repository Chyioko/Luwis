﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void hrat()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

}
 

