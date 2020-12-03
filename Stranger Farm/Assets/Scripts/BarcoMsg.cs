using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarcoMsg : MonoBehaviour
{
    public Text junteMoney;

    private void Start()
    {
        junteMoney.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            print("djfgosfj");
            junteMoney.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            junteMoney.enabled = false;
        }
    }
}
