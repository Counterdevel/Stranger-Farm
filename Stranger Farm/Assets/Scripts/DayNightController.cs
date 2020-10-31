using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public GameObject targetLight;
    public GameObject targetMainCamera;
    //public Material[] skys;
    public float DayTimer;
    public bool isCycle;
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
        if (!isCycle)
        {
            targetLight.GetComponent<Light>().intensity = DayTimer -= Time.deltaTime * 0.1f;
            if(DayTimer <= 0)
            {
                isCycle = true;
            }
        }
        else if (isCycle)
        {
            targetLight.GetComponent<Light>().intensity = DayTimer += Time.deltaTime * 0.3f;
            if (DayTimer >= 1)
            {
                isCycle = false;
            }
        }
        //ChangeCycle();
    }

    /*/void ChangeCycle()
    {
        if (DayTimer >= 0.9f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[0];
        }
        else if (DayTimer >= 0.5f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[1];
        }
        else if (DayTimer >= 0.3f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[2];
        }
        else if (DayTimer >= 0.1f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[3];
        }
    }
    /*/
}
