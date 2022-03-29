using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggered : MonoBehaviour
{
    public bool buttonActive = false;

    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            buttonActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            buttonActive = false;
        }
    }

    private void Update()
    {
        if (buttonActive == true)
        {
            this.gameObject.tag = "pressed";
        }
        else
        {
            this.gameObject.tag = "Untagged";
        }
    }
}
