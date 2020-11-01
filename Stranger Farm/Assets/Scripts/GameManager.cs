using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static string currentToll = "nenhuma";

    public static int SementesDeBroto = 5;
    public static int SementesDeBatata= 4;
    public static int SementesDeCenoura = 3;

    public Text Ferramenta;
    private void Update()
    {
        Ferramenta.text = currentToll;
    }
}
