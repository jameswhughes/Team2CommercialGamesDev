using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{

    private float lockPos = 0;   

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);
    }
}
