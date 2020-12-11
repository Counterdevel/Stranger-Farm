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
    public Sprite frutof1;
    public Sprite frutof2;
    public Sprite frutof3;

    public Sprite semente2;
    public Sprite fruto2f1;
    public Sprite fruto2f2;
    public Sprite fruto2f3;

    public Sprite semente3;
    public Sprite fruto3f1;
    public Sprite fruto3f2;
    public Sprite fruto3f3;

    Vector3 pos;
    Quaternion rot;

    bool madura = false;
    bool sujo = false;
    bool verde = false;
    public bool chão = false;

    private void Start()
    {
        pos = transform.position;
        rot = transform.rotation;
    }
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
                GetComponent<SpriteRenderer>().sprite = frutof1;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92,255);
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.localPosition = new Vector3(0, 0, 0.6f);
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                if (growTime > 8)
                {
                    GetComponent<SpriteRenderer>().sprite = frutof2;
                    if(growTime > 10)
                    {
                        GetComponent<SpriteRenderer>().sprite = frutof3;
                        madura = true;
                    }
                }
            }
        }
        if ((growTime > 9) && (watered == "yes"))
        {
            if (CurrentSeed == "semente2")
            {
                GetComponent<SpriteRenderer>().sprite = fruto2f1;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.localPosition = new Vector3(0, 0, 0.6f);
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                if (growTime > 18)
                {
                    GetComponent<SpriteRenderer>().sprite = fruto2f2;
                    if (growTime > 27)
                    {
                        GetComponent<SpriteRenderer>().sprite = fruto2f3;
                        madura = true;
                    }
                }
            }
        }
        if ((growTime > 12) && (watered == "yes"))
        {
            if (CurrentSeed == "semente3")
            {
                GetComponent<SpriteRenderer>().sprite = fruto3f1;
                terra.GetComponent<SpriteRenderer>().color = new Color32(125, 97, 92, 255);
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.localPosition = new Vector3(0, 0, 0.6f);

                if (growTime > 24)
                {
                    GetComponent<SpriteRenderer>().sprite = fruto3f2;
                    if (growTime > 36)
                    {
                        GetComponent<SpriteRenderer>().sprite = fruto3f3;
                        madura = true;
                    }
                }
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
                                transform.position = pos;
                                transform.rotation = rot;
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
                            transform.position = pos;
                            transform.rotation = rot;
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
                            transform.position = pos;
                            transform.rotation = rot;
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
                        if (GetComponent<SpriteRenderer>().sprite == noPlant && GameManager.Instance.sementesRestantes > 0)
                        {
                            GetComponent<SpriteRenderer>().sprite = semente;
                            CurrentSeed = "semente1";
                            GameManager.Instance.Plantado(1);
                            GameManager.Instance.EnergyLost(1);
                        }
                    }
            break;

                case "semente2":
                    if (GetComponent<SpriteRenderer>().sprite == noPlant && GameManager.Instance.sementesRestantes2 > 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = semente2;
                        CurrentSeed = "semente2";
                        GameManager.Instance.Plantado2(1);
                        GameManager.Instance.EnergyLost(1);
                    }
                    break;

                case "semente3":
                    if (GetComponent<SpriteRenderer>().sprite == noPlant && GameManager.Instance.sementesRestantes3 > 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = semente3;
                        CurrentSeed = "semente3";
                        GameManager.Instance.Plantado3(1);
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
