using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWhenCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public string ColliderTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ColliderTag && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ColliderTag && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
