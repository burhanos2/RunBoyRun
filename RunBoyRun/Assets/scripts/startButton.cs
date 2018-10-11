using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

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
<<<<<<< HEAD
    
=======

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(WareHouse._jumpButton))
        { TaskOnClick(); }
    }
>>>>>>> 6500563a7f1dae21b64c4d2eda8be77a703708b5
}
