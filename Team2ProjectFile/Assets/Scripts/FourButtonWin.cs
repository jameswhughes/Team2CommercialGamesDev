using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourButtonWin : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public string LevelName;

    void Update()
    {
        if (button1.gameObject.tag == "pressed" && button2.gameObject.tag == "pressed" 
            && button3.gameObject.tag == "pressed" && button4.gameObject.tag == "pressed")
        {
            StartCoroutine(WaitForIt());
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName: LevelName);
    }
}
