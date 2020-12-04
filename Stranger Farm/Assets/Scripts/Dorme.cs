using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dorme : MonoBehaviour
{

    public GameObject pressione;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressione.SetActive(true);
            //print("Dormiu");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Calendario.Instance.Dormir(08, true);
                Calendario.day++;
                GameManager.Instance.RechargedEnergy(100);
                DayNightController.DayTimer = 1;
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pressione.SetActive(false);
        }
    }
}
