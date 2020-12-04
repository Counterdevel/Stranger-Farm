using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarcoMsg : MonoBehaviour
{
    public GameObject junteMoney;

    private void Start()
    {
        junteMoney.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            junteMoney.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            junteMoney.SetActive(false);
        }
    }
}
