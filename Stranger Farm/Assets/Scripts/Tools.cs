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
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select.enabled = true;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            GameManager.currentToll = "enxada";
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select1.enabled = true;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            GameManager.currentToll = "agua";
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select2.enabled = true;
        }
        Debug.Log(GameManager.currentToll);
    }


}
