using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOverMultipleScenes : MonoBehaviour
{
    public AudioSource soundTrack;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PlayMusic()
    {
        if (soundTrack.isPlaying) return;
        soundTrack.Play();
    }

    public void StopMusic()
    {
        soundTrack.Stop();
    }
}
