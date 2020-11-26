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

    public Text Ferramenta;

    int venda = 0;
    public Text DinheiroTXT;

    int energia = 100;
    public Text energiaPorcentagem;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }

    }
    private void Update()
    {
        Ferramenta.text = currentToll;
    }
    public void AddPoint(int value)
    {
        venda += value;
        DinheiroTXT.text = venda.ToString();
    }

    public void EnergyLost(int energiaGasta)
    {
        energia -= energiaGasta;
        energiaPorcentagem.text = energia.ToString();
    }

    public void RechargedEnergy(int recharge)
    {
        energia = recharge;
        energiaPorcentagem.text = energia.ToString();
    }
}
