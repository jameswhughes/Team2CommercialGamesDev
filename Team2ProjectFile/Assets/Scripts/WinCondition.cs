using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WinCondition : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public string NextLevelName;
    public Canvas canvas;
    public TextMeshProUGUI timerText;
    
    void Update()
    {
        if (button1.gameObject.tag == "pressed" && button2.gameObject.tag == "pressed")
        {
            StartCoroutine(WaitForIt());
            canvas.GetComponent<UITimer>().playing = false;
        }

        
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName: NextLevelName);
        timerText.enabled = false;
    }
}
