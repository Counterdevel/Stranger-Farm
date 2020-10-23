using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CercaQuinaRotate : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.Rotate(0f, 0f, -90f);
        }
    }
}
