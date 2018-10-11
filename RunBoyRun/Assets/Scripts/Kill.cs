using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kill")
        {
            SceneManager.LoadScene("menu");

        }
    }
<<<<<<< HEAD:RunBoyRun/Assets/Scripts/Kill.cs
=======

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "kill")
        {
            SceneManager.LoadScene("menu");

        }
    }
}
>>>>>>> 6500563a7f1dae21b64c4d2eda8be77a703708b5:RunBoyRun/Assets/Scripts/Kill.cs

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kill")
        {
            SceneManager.LoadScene("menu");

        }
    }
}