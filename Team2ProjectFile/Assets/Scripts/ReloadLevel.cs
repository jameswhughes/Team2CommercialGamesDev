using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ReloadLevel : MonoBehaviour
{

    public string ThisLevelName;
    public bool restarted;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(WaitForIt());
        }
    }

    void TaskOnClick()
    {
        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName: ThisLevelName);
        restarted = true;
    }
}
