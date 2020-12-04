using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    public GameObject PanelFerramentas;
    public GameObject PanelSementes;
    public GameObject ButtonVoltar;
    public GameObject BotaoFerramentas;
    public GameObject BotaoSementes;

    public GameObject BotaoComprarS1;
    public GameObject BotaoComprarS2;
    public GameObject BotaoComprarS3;

    public static float carteira;

    public void ComprarSemente()
    {
        PanelSementes.SetActive(true);
        ButtonVoltar.SetActive(true);
        BotaoFerramentas.SetActive(false);
        BotaoSementes.SetActive(false);
    }
    public void ComprarFerramenta()
    {
        PanelFerramentas.SetActive(true);
        ButtonVoltar.SetActive(true);
        BotaoFerramentas.SetActive(false);
        BotaoSementes.SetActive(false);
    }

    public void Voltar()
    {
        PanelFerramentas.SetActive(false);
        PanelSementes.SetActive(false);
        ButtonVoltar.SetActive(false);
        BotaoFerramentas.SetActive(true);
        BotaoSementes.SetActive(true);
    }

    public void ComprouSemente1()
    {
        if (GameManager.Instance.venda > 0.50f)
        {
            carteira -= 0.50f;
            GameManager.Instance.RemovePoint(0.50f);
            GameManager.Instance.sementesRestantes += 1;
        }
    }

    public void ComprouSemente2()
    {
        if (GameManager.Instance.venda > 1.75f)
        { 
            carteira -= 1.75f;
            GameManager.Instance.RemovePoint(1.75f);
            GameManager.Instance.sementesRestantes2 += 1;
        }
    }
    public void ComprouSemente3()
    {
        if (GameManager.Instance.venda > 3.00f)
        {
            carteira -= 3.00f;
            GameManager.Instance.RemovePoint(3.00f);
            GameManager.Instance.sementesRestantes3 += 1;
        }
    }

    public void PassagemBarco()
    {
        if (GameManager.Instance.venda > 500f)
        {
            carteira -= 500f;
            GameManager.Instance.RemovePoint(500f);
        }
    }

    public void FecharLoja()
    {
        this.gameObject.SetActive(false);
    }
}
