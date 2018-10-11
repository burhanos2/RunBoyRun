﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public Button btn;
    // Use this for initialization
    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);

        
    }

    private void TaskOnClick()
    {
        SceneManager.LoadScene("RunBoyRun");
    }
    

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(WareHouse._jumpButton))
        { TaskOnClick(); }
    }

  
}
