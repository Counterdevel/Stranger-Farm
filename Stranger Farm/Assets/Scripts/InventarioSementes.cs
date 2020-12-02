using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioSementes : MonoBehaviour
{
    public Text SementesDeBroto;
    public Text SementesDeBatata;
    public Text SementesDeCenoura;
    void Start()
    {
        SementesDeBroto.text = "" + GameManager.Instance.sementesRestantes;
        SementesDeBatata.text = "" + GameManager.Instance.sementesRestantes2;
        SementesDeCenoura.text = "" + GameManager.Instance.sementesRestantes3;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha4))
        {
            GameManager.currentToll = "semente1";
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select3.enabled = true;
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            GameManager.currentToll = "semente2";
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select4.enabled = true;
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            GameManager.currentToll = "semente3";
            GameManager.Instance.DesativaSelects();
            GameManager.Instance.Select5.enabled = true;
        }
    }
}
