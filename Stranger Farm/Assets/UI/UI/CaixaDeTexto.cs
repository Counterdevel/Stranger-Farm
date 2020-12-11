using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class CaixaDeTexto : MonoBehaviour
{
    public bool aviso = true;
    public GameObject instru;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            aviso = false;
            instru.SetActive(true);
        }
        if (aviso == false)
        {
            Destroy(this.gameObject);
        }

    }
}