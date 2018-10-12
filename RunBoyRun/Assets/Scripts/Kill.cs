using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    private void Start()
    {
        WareHouse.dead = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kill")
        {
            SceneManager.LoadScene("menu");
            WareHouse.dead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kill"|| collision.gameObject.tag == "Spikez")
        {
            SceneManager.LoadScene("menu");
            WareHouse.dead = true;

        }
    }
}