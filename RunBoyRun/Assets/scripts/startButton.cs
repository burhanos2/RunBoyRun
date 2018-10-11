using System.Collections;
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
<<<<<<< HEAD

=======
    
>>>>>>> 3794cd20fae3805c82fd85ca6653c0ae1d77bea1

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(WareHouse._jumpButton))
        { TaskOnClick(); }
    }

<<<<<<< HEAD
=======
  
>>>>>>> 3794cd20fae3805c82fd85ca6653c0ae1d77bea1
}
