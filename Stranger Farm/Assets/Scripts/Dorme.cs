﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dorme : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Dormiu");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Calendario.Instance.Dormir(08, true);
                GameManager.Instance.RechargedEnergy(100);
            }
        }
    }
}
