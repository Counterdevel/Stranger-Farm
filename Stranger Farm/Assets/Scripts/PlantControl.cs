using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControl : MonoBehaviour
{
    public Sprite noPlant;
    public Sprite broto;
    public Sprite flor;

    public Sprite batata;
    public Sprite brotoBatata;

    public Sprite cenoura;
    public Sprite brotoCenoura;

    public GameObject broto3d;
    public GameObject flor3d;

    public GameObject terra;

    public string CurrentSeed;

    public float growTime = 0;
    public string watered = "no";

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
            }
            if (CurrentSeed == "cenoura")
            {
                GetComponent<SpriteRenderer>().sprite = cenoura;
            }
            if (CurrentSeed == "batata")
            {
                GetComponent<SpriteRenderer>().sprite = batata;
            }
        }


    }
    private void OnMouseDown()
    {
        //Debug.Log("sai fora tio clica em mim nao");
        if(GameManager.currentToll == "foice")
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        if ((GameManager.currentToll == "broto") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = broto;
            CurrentSeed = "broto";
        }
        if ((GameManager.currentToll == "cenoura") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = brotoCenoura;
            CurrentSeed = "cenoura";
        }
        if ((GameManager.currentToll == "batata") && (GetComponent<SpriteRenderer>().sprite == noPlant))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = brotoBatata;
            CurrentSeed = "batata";
        }
        if (GameManager.currentToll == "agua")
        {
            //Destroy(gameObject);
            terra.GetComponent<SpriteRenderer>().color = Color.blue;
            watered = "yes";
        }
    }
}
