using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bau : MonoBehaviour
{
    bool loja = false;

    public GameObject LojaPanel;
    public GameObject pressione;


    // Update is called once per frame
    void Update()
    {
        if (loja == true && Input.GetKey(KeyCode.E))
        {
            LojaPanel.SetActive(true);
            pressione.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            loja = true;
        }

    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            loja = true;
            pressione.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            loja = false;
            pressione.SetActive(false);
            LojaPanel.SetActive(false);
        }
    }
}
