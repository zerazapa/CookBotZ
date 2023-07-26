using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    public float maxTime;
    bool isCounting;
    public static bool isBeggining;

    public float mins;
    public float minsShow;
    public float secs;
    public static bool isStarting = true;
    public static bool isGameOver = false;
    public static string estaescena;

    TextMeshProUGUI textMeshProUGUI; // Referencia al componente TextMeshProUGUI

    public Transform timeShown;
    bool hasMoved = false;

    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        time = maxTime;
        isBeggining = true;
        isGameOver = false;
        isCounting = false;
        estaescena = SceneManager.GetActiveScene().name;
        timeShown = GameObject.Find("timeShown").transform;
    }

    void Update()
    {
        if (NarradorScript.appearTime && !hasMoved)
        {
            timeShown.position = new Vector2(0, 5.4f);
            hasMoved = true;
        }

        StartCoroutine(Begin());

        if (time == maxTime)
        {
            isStarting = true;
        }
        else
        {
            isStarting = false;
        }
        
        if ((time > 0f && !isCounting && !isBeggining) && !isGameOver)
        {
            if (SceneManager.GetActiveScene().name == "tuto")
            {
                if (NarradorScript.appearTime)
                {
                    StartCoroutine(Tick());
                }
            }
            else
            {
                StartCoroutine(Tick());
            }
            
        }

        mins = time / 60f;

        if (mins >= 5f && mins < 6f)
        {
            minsShow = 5f;
        }
        else if (mins > 4f && mins < 5f)
        {
            minsShow = 4f;
        }
        else if (mins >= 3f && mins < 4f)
        {
            minsShow = 3f;
        }
        else if (mins > 2f && mins < 3f)
        {
            minsShow = 2f;
        }
        else if (mins > 1f && mins < 2f)
        {
            minsShow = 1f;
        }
        else if (mins < 1f)
        {
            minsShow = 0f;
        }

        secs = time - (minsShow * 60f);

        string minsShowString = minsShow.ToString();
        string secsString = secs.ToString();

        if (secsString == "9")
        {
            secsString = "09";
        }
        if (secsString == "8")
        {
            secsString = "08";
        }
        if (secsString == "7")
        {
            secsString = "07";
        }
        if (secsString == "6")
        {
            secsString = "06";
        }
        if (secsString == "5")
        {
            secsString = "05";
        }
        if (secsString == "4")
        {
            secsString = "04";
        }
        if (secsString == "3")
        {
            secsString = "03";
        }
        if (secsString == "2")
        {
            secsString = "02";
        }
        if (secsString == "1")
        {
            secsString = "01";
        }
        if (secsString == "0")
        {
            secsString = "00";
        }

        if (textMeshProUGUI.gameObject.name == "tiempomins") // Verifica si el objeto de TextMeshProUGUI tiene el nombre "tiempomins"
        {
            textMeshProUGUI.text = minsShowString; // Asigna el valor de minsShowString al componente TextMeshProUGUI
        }
        if (textMeshProUGUI.gameObject.name == "tiemposecs") // Verifica si el objeto de TextMeshProUGUI tiene el nombre "tiemposecs"
        {
            textMeshProUGUI.text = secsString; // Asigna el valor de minsShowString al componente TextMeshProUGUI
        }

        if (time == 0)
        {
            Score.endForTime = true;
        }
    }

    IEnumerator Tick()
    {
        isCounting = true;
        yield return new WaitForSeconds(1f);
        time = time - 1;
        isCounting = false;
    }


    IEnumerator Begin()
    {
        yield return new WaitForSeconds(2f);
        isBeggining = false;
    }
}
