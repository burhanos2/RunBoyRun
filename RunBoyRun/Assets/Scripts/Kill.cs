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
<<<<<<< HEAD

=======
>>>>>>> 3794cd20fae3805c82fd85ca6653c0ae1d77bea1

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kill")
        {
            SceneManager.LoadScene("menu");

        }
    }
}