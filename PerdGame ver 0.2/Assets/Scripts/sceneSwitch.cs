﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadScene", 48f);
    }
    void loadScene()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
