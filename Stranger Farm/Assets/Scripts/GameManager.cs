using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static string currentToll = "nenhuma";

    public Image Select;
    public Image Select1;
    public Image Select2;
    public Image Select3;
    public Image Select4;
    public Image Select5;

    public float venda = 0;
    public Text DinheiroTXT;

    public int energia = 100;
    public Text energiaPorcentagem;

    public int sementesRestantes = 3;
    public Text sementesDisponiveis;

    public int sementesRestantes2 = 0;
    public Text sementesDisponiveis2;

    public int sementesRestantes3 = 0;
    public Text sementesDisponiveis3;

    public GameObject gameover;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        DesativaSelects();
    }

    private void Update()
    {
        Loja.carteira = venda;
        sementesDisponiveis.text = sementesRestantes.ToString();
        sementesDisponiveis2.text = sementesRestantes2.ToString();
        sementesDisponiveis3.text = sementesRestantes3.ToString();
        GameOver();
    }
    public void AddPoint(float value)
    {
        venda += value;
        DinheiroTXT.text = venda.ToString();
    }

    public void RemovePoint(float value)
    {
        venda -= value;
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

    public void Plantado(int plantou)
    {
        sementesRestantes -= plantou;
        sementesDisponiveis.text = sementesRestantes.ToString();
    }

    public void Plantado2(int plantou)
    {
        sementesRestantes2 -= plantou;
        sementesDisponiveis2.text = sementesRestantes2.ToString();
    }

    public void Plantado3(int plantou)
    {
        sementesRestantes3 -= plantou;
        sementesDisponiveis3.text = sementesRestantes3.ToString();
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

    public void GameOver()
    {
        if (venda == 0 && sementesRestantes == 0 && sementesRestantes2 == 0 && sementesRestantes3 == 0 && Calendario.hour == 02 || energia == 0)
        {
            gameover.SetActive(true);
        }
    }
}
