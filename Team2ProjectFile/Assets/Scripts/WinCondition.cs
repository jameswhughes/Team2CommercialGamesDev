using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public string NextLevelName;
    
    void Update()
    {
        if (button1.gameObject.tag == "pressed" && button2.gameObject.tag == "pressed")
        {
            StartCoroutine(WaitForIt());
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName: NextLevelName);
    }
}
