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
        float carteira = GameManager.venda;
        carteira -= 0.50f;
        GameManager.Instance.RemovePoint(carteira);
        if(carteira < 0.50f)
        {
            print("Dinheiro insuficiente!");
        }
    }

    public void FecharLoja()
    {
        this.gameObject.SetActive(false);
    }
}
