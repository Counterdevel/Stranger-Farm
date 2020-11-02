using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantControl : MonoBehaviour
{
    public Sprite noPlant;

    public Sprite broto;
    public Sprite flor;

    public Sprite batata;
    public Sprite brotoBatata;

    public Sprite cenoura;
    public Sprite brotoCenoura;

    public GameObject terra;

    public GameObject broto3d;
    
    public string CurrentSeed;

    public float growTime = 0;
    public string watered = "no";


    void Update()
    {
       if(CurrentSeed != "")
        {
            growTime += Time.deltaTime;
        }
       if((growTime > 4) && (watered == "no"))
        {
            CurrentSeed = "";
            growTime = 0;
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if ((growTime > 6) && (watered == "yes"))
        {
            if(CurrentSeed == "broto")
            {
                GetComponent<SpriteRenderer>().sprite = flor;
                //Instantiate(broto3d, terra.transform.position, terra.transform.rotation);
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92,255);
            }
        }
        if ((growTime > 12) && (watered == "yes"))
        {
            if (CurrentSeed == "cenoura")
            {
                GetComponent<SpriteRenderer>().sprite = cenoura;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            }
        }
        if ((growTime > 9) && (watered == "yes"))
        {
            if (CurrentSeed == "batata")
            {
                GetComponent<SpriteRenderer>().sprite = batata;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            }
        }

    }
    private void OnMouseDown()
    {
        if(GameManager.currentToll == "foice")
        {
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if ((GameManager.currentToll == "foice") && (CurrentSeed == "broto"))
        {
            GameManager.Instance.AddPoint(2);
            CurrentSeed = "";
            GetComponent<SpriteRenderer>().sprite = noPlant;
            terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            growTime = 0;
            watered = "no";
}
        if ((GameManager.currentToll == "foice") && (CurrentSeed == "batata"))
        {
            GameManager.Instance.AddPoint(4);
            CurrentSeed = "";
            GetComponent<SpriteRenderer>().sprite = noPlant;
            terra.GetComponent<SpriteRenderer>().color = new Color32(125,97,92,255);
            growTime = 0;
            watered = "no";
        }
        if ((GameManager.currentToll == "foice") && (CurrentSeed == "cenoura"))
        {
            GameManager.Instance.AddPoint(6);
            CurrentSeed = "";
            GetComponent<SpriteRenderer>().sprite = noPlant;
            terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            growTime = 0;
            watered = "no";
        }


        if (GameManager.currentToll == "enxada")
        {

        }


        if ((GameManager.currentToll == "broto") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            GetComponent<SpriteRenderer>().sprite = broto;
            CurrentSeed = "broto";
        }


        if ((GameManager.currentToll == "cenoura") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            GetComponent<SpriteRenderer>().sprite = brotoCenoura;
            CurrentSeed = "cenoura";
        }


        if ((GameManager.currentToll == "batata") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            GetComponent<SpriteRenderer>().sprite = brotoBatata;
            CurrentSeed = "batata";
        }


        if (GameManager.currentToll == "agua")
        {
            terra.GetComponent<SpriteRenderer>().color = new Color32(37,112,214,255);
            watered = "yes";
        }
    }
}
