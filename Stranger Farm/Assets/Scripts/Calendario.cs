using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calendario : MonoBehaviour
{
    public static Calendario Instance;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }

    }

    private const int TIMESCALE = 3600; //1 second = 30 minute

    public Text ClockText;
    public Text DayText;
    public Text SeasonText;
    public Text YearText;

    public static double minute, hour, day, second, month, year;
    void Start()
    {
        month = 1;
        day = 1;
        year = 2020;
        hour = 08;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
        CalculateSeason();

        if(hour == 03)
        {
            hour = 08;
            GameManager.Instance.RechargedEnergy(50);
        }
    }

    void TextCallFunction()
    {
        DayText.text = "Dia: " + day;
        ClockText.text = string.Format("Horas: " + "{0:00}:{1:00}", hour, minute);
        YearText.text = "Ano: " + year;
    }

    void CalculateSeason()
    {
        if (month == 12 || month == 1 || month == 2 || month == 3)
        {
            SeasonText.text = "Verão";
        }
        if (month == 4 || month == 5 || month == 6)
        {
            SeasonText.text = "Outono";
        }
        if (month == 7 || month == 8 || month == 9)
        {
            SeasonText.text = "Inverno";
        }
        if (month == 10 || month == 11)
        {
            SeasonText.text = "Primavera";
        }
    }

    void CalculateMonth()
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day >= 32)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
        if (month == 2)
        {
            month++;
            day = 1;
            TextCallFunction();
            CalculateSeason();
        }
    }

    void CalculateTime()
    {
        second += Time.deltaTime * TIMESCALE;

        if (second >= 60)
        {
            minute++;
            second = 0;
            TextCallFunction();
        }
        else if (minute >= 60)
        {
            hour++;
            minute = 0;
            TextCallFunction();
        }
        else if (hour >= 24)
        {
            day++;
            hour = 0;
            TextCallFunction();
        }
        else if (day >= 28)
        {
            CalculateMonth();
        }
        else if (month > 12)
        {
            month = 1;
            year++;
            TextCallFunction();
            CalculateSeason();
        }
    }

    public void Dormir(double wakeMeUp, bool dormiu = false)
    {
        if (dormiu == true)
        {
            hour = wakeMeUp;
            dormiu = false;
        }
    }
}
