using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesUI : MonoBehaviour
{

    string NomeDaCena;
    public string nomeCena;
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
}
