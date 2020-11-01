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

    //public GameObject broto3d;
    //public GameObject flor3d;

    public GameObject terra;
    

    public string CurrentSeed;

    public float growTime = 0;
    public string watered = "no";

    int venda;
    public Text DinheiroTXT;

    void Update()
    {
       if(CurrentSeed != "")
        {
            growTime += Time.deltaTime;
        }
       if((growTime > 5) && (watered == "no"))
        {
            CurrentSeed = "";
            growTime = 0;
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if ((growTime > 5) && (watered == "yes"))
        {
            if(CurrentSeed == "broto")
            {
                GetComponent<SpriteRenderer>().sprite = flor;
                terra.GetComponent<SpriteRenderer>().color = new Color(125, 97, 92);

            }
            if (CurrentSeed == "cenoura")
            {
                GetComponent<SpriteRenderer>().sprite = cenoura;
                terra.GetComponent<SpriteRenderer>().color = new Color(125, 97, 92);
            }
            if (CurrentSeed == "batata")
            {
                GetComponent<SpriteRenderer>().sprite = batata;
                terra.GetComponent<SpriteRenderer>().color = new Color(125, 97, 92);
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Venda();
        }


    }
    private void OnMouseDown()
    {
        if(GameManager.currentToll == "foice")
        {
            GetComponent<SpriteRenderer>().sprite = noPlant;
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
            terra.GetComponent<SpriteRenderer>().color = new Color(121, 161, 255);
            watered = "yes";
        }
    }

    void Venda()
    {
        if(GetComponent<SpriteRenderer>().sprite == brotoCenoura)
        {
            AddPoint(5);
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if (GetComponent<SpriteRenderer>().sprite == broto)
        {
            AddPoint(2);
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if (GetComponent<SpriteRenderer>().sprite == brotoBatata)
        {
            AddPoint(4);
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
    }

    void AddPoint(int value)
    {
        venda += value;
        DinheiroTXT.text = venda.ToString();
    }
}
