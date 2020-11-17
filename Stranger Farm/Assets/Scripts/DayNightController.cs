using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public GameObject targetLight;
    public GameObject targetMainCamera;

    public float DayTimer;
    public bool isCycle = false;

    public static string horario;
    private void Awake()
    {
        targetLight = GameObject.FindGameObjectWithTag("Light");
        targetMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Start()
    {
        DayTimer = targetLight.GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Calendario.hour >= 18 && Calendario.hour <= 22)
        {
            targetLight.GetComponent<Light>().intensity = DayTimer -= Time.deltaTime * 0.1f;
            targetLight.GetComponent<Light>().color = new Color32(43, 37, 152, 255);
            if (DayTimer <= 0.5)
            {
                isCycle = true;
            }
        }
        else if (Calendario.hour >= 5 && Calendario.hour <= 6 && isCycle == true)
        {
            targetLight.GetComponent<Light>().intensity = DayTimer += Time.deltaTime * 0.4f;
            targetLight.GetComponent<Light>().color = new Color32(255,244,214,255);
            if(DayTimer >= 1)
            {
                isCycle = false;
            }
        }
        
    }
}
