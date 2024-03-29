using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevrilecekObje : MonoBehaviour
{
    public AudioSource Sise;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Top" || collision.gameObject.name == "Top2")
        {
            Sise.Play();
        }
    }
}