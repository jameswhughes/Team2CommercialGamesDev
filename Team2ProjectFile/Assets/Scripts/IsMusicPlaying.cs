using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMusicPlaying : MonoBehaviour
{    
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<PlayMusicOverMultipleScenes>().PlayMusic();
    }
}
