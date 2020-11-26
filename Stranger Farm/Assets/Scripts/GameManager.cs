using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static string currentToll = "nenhuma";

    public static int SementesDeBroto;
    public static int SementesDeBatata;
    public static int SementesDeCenoura;

    public Image Select;
    public Image Select1;
    public Image Select2;
    public Image Select3;
    public Image Select4;
    public Image Select5;

    int venda = 0;
    public Text DinheiroTXT;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        DesativaSelects();
    }
     public void AddPoint(int value)
    {
        venda += value;
        DinheiroTXT.text = venda.ToString();
    }

    public void DesativaSelects()
    {
        Select.enabled  = false;
        Select1.enabled = false;
        Select2.enabled = false;
        Select3.enabled = false;
        Select4.enabled = false;
        Select5.enabled = false;
    }
}
