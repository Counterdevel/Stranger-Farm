using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CercaRotate : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.Rotate(0f, 0f, -90f);
        }
    }
}
