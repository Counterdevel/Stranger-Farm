using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruções : MonoBehaviour
{
    public GameObject instru;

    public void Abreinstru()
    {
        instru.SetActive(true); 
    }
    public void Fechainstru()
    {
        instru.SetActive(false);
    }
}
