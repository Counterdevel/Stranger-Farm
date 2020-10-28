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
        SementesDeBroto.text = "Sementes de Broto: " + GameManager.SementesDeBroto;
        SementesDeBatata.text = "Sementes de Batata: " + GameManager.SementesDeBatata;
        SementesDeCenoura.text = "Sementes de Cenoura: " + GameManager.SementesDeCenoura;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha4))
        {
            GameManager.currentToll = "broto";
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            GameManager.currentToll = "cenoura";
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            GameManager.currentToll = "batata";
        }
    }
}
