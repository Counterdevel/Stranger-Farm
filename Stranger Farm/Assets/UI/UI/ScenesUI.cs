using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesUI : MonoBehaviour
{

    string NomeDaCena;
    public string nomeCena;
    public GameObject PanelOpcoes;
    public GameObject PanelCreditos;
    public GameObject PanelInicial;
    public GameObject ButtonBack;

    private void Awake()
    {
        PanelOpcoes.SetActive(false);
        PanelCreditos.SetActive(false);
        PanelInicial.SetActive(true);
        ButtonBack.SetActive(false);
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        NomeDaCena = SceneManager.GetActiveScene().name;
    }


    public void LoadScene(string sceneName)
    {
        nomeCena = sceneName;
        StartCoroutine("Abrir");
    }

    private IEnumerator Abrir ()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(nomeCena);
    }

    public void Reload()
    {
        SceneManager.LoadScene(NomeDaCena);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Opcoes()
    {
        PanelOpcoes.SetActive(true);
        PanelCreditos.SetActive(false);
        PanelInicial.SetActive(false);
        ButtonBack.SetActive(true);
    }
    public void Creditos()
    {
        PanelOpcoes.SetActive(false);
        PanelCreditos.SetActive(true);
        PanelInicial.SetActive(false);
        ButtonBack.SetActive(true);
    }
    public void Voltar()
    {
        PanelOpcoes.SetActive(false);
        PanelCreditos.SetActive(false);
        PanelInicial.SetActive(true);
        ButtonBack.SetActive(false);
    }
}
