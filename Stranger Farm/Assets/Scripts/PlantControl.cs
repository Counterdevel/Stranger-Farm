using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BitCodeSaveSystem;

public class PlantControl : MonoBehaviour
{
    public string CurrentSeed;
    public string watered = "no";
    public float growTime = 0;

    public Sprite noPlant;
    public GameObject terra;

    public Sprite semente;
    public Sprite fruto;

    public Sprite semente2;
    public Sprite fruto2;

    public Sprite semente3;
    public Sprite fruto3;

    bool madura = false;
    bool sujo = false;
    bool verde = false;
    public bool chão = false;
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
            if(CurrentSeed == "semente1")
            {

                GetComponent<SpriteRenderer>().sprite = fruto;
                madura = true;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92,255);
            }
        }
        if ((growTime > 12) && (watered == "yes"))
        {
            if (CurrentSeed == "semente2")
            {
                GetComponent<SpriteRenderer>().sprite = fruto3;
                madura = true;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            }
        }
        if ((growTime > 9) && (watered == "yes"))
        {
            if (CurrentSeed == "semente3")
            {
                GetComponent<SpriteRenderer>().sprite = fruto2;
                madura = true;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
            }
        }

    }
    private void OnMouseDown()
    {
        switch (GameManager.currentToll)
        {
            case "foice":
                if(chão == true)
                { 
                    if(sujo == true && verde == false)
                    {
                        GetComponent<SpriteRenderer>().sprite = noPlant;
                        sujo = false;
                        GameManager.Instance.EnergyLost(2);
                    }
                        if(CurrentSeed == "semente1")
                        {
                            if(madura == true)
                            {
                                GameManager.Instance.AddPoint(2);
                                GameManager.Instance.EnergyLost(1);
                                CurrentSeed = "";
                                GetComponent<SpriteRenderer>().sprite = noPlant;
                                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                                growTime = 0;
                                madura = false;
                                watered = "no";
                            }
                        }
                    if(CurrentSeed == "semente2")
                    {
                        if (madura == true)
                        {
                            GameManager.Instance.AddPoint(4);
                            GameManager.Instance.EnergyLost(1);
                            CurrentSeed = "";
                            GetComponent<SpriteRenderer>().sprite = noPlant;
                            terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                            growTime = 0;
                            madura = false;
                            watered = "no";
                        }
                    }
                        if (CurrentSeed == "semente3")
                        {
                        if (madura == true)
                        {
                            GameManager.Instance.AddPoint(6);
                            GameManager.Instance.EnergyLost(1);
                            CurrentSeed = "";
                            GetComponent<SpriteRenderer>().sprite = noPlant;
                            terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                            growTime = 0;
                            madura = false;
                            watered = "no";
                        }
                 }
                }
            break;

                case "agua":

                if (chão == true)
                {
                    terra.GetComponent<SpriteRenderer>().color = new Color32(37, 112, 214, 255);
                    watered = "yes";
                    GameManager.Instance.EnergyLost(1);
                }
                if (chão == true) 
                    { 
                    terra.GetComponent<SpriteRenderer>().color = new Color32(37, 112, 214, 255);
                    watered = "yes";
                    }
                    break;

                case "enxada":
                if (chão == true)
                    { 
                        terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                        GetComponent<SpriteRenderer>().color = new Color32(159, 74, 20, 255);
                        GameManager.Instance.EnergyLost(3);
                        sujo = true;
                        verde = false;
                    }
            break;

                case "semente1":
                if (chão == true) 
                    { 
                        if (GetComponent<SpriteRenderer>().sprite == noPlant)
                        {
                            GetComponent<SpriteRenderer>().sprite = semente;
                            CurrentSeed = "semente1";
                            GameManager.Instance.EnergyLost(1);
                    }
                    }
            break;

                case "semente2":
                if (GetComponent<SpriteRenderer>().sprite == noPlant)
                    {
                        GetComponent<SpriteRenderer>().sprite = semente;
                        CurrentSeed = "semente2";
                        GameManager.Instance.EnergyLost(1);
                    }
                    break;

                case "semente3":
                if (GetComponent<SpriteRenderer>().sprite == noPlant)
                    {
                        GetComponent<SpriteRenderer>().sprite = semente;
                        CurrentSeed = "semente3";
                        GameManager.Instance.EnergyLost(1);
                }
                    break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            chão = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            chão = false;
        }
    }
}
