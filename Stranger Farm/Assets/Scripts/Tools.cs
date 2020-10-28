using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tools : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            GameManager.currentToll = "foice";
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            GameManager.currentToll = "agua";
        }
        Debug.Log(GameManager.currentToll);
    }


}
