using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarradorScript : MonoBehaviour
{
    public static string narrador;
    public static bool texto1 = true;
    public static bool stopp = true;
    bool hasWon = false;
    TextMeshProUGUI textMeshProUGUI;
    
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        texto1 = false;
        stopp = true;
    }

    void Update()
    {
        textMeshProUGUI.text = narrador;

        if (Score.youWin && !hasWon)
        {
            hasWon = true;
            StartCoroutine(WinText());
        }
        if (Score.youLoose && !hasWon)
        {
            hasWon = true;
            StartCoroutine(LooseText());
        }

    }

    IEnumerator WinText()
    {
        stopp = false;
        narrador = "f";
        yield return new WaitForSeconds(0.175f);
        narrador = "fe";
        yield return new WaitForSeconds(0.175f);
        narrador = "fel";
        yield return new WaitForSeconds(0.175f);
        narrador = "feli";
        yield return new WaitForSeconds(0.175f);
        narrador = "felic";
        yield return new WaitForSeconds(0.175f);
        narrador = "felici";
        yield return new WaitForSeconds(0.175f);
        narrador = "felicid";
        yield return new WaitForSeconds(0.175f);
        narrador = "felicida";
        yield return new WaitForSeconds(0.175f);
        narrador = "felicidad";
        yield return new WaitForSeconds(0.175f);
        narrador = "felicidade";
        yield return new WaitForSeconds(0.175f);
        narrador = "felicidades";
        yield return new WaitForSeconds(0.175f);
        stopp = true;
    }
    IEnumerator LooseText()
    {
        stopp = false;
        narrador = "q";
        yield return new WaitForSeconds(0.175f);
        narrador = "qu";
        yield return new WaitForSeconds(0.175f);
        narrador = "que";
        yield return new WaitForSeconds(0.175f);
        narrador = "que ";
        yield return new WaitForSeconds(0.175f);
        narrador = "que l";
        yield return new WaitForSeconds(0.175f);
        narrador = "que la";
        yield return new WaitForSeconds(0.175f);
        narrador = "que las";
        yield return new WaitForSeconds(0.175f);
        narrador = "que last";
        yield return new WaitForSeconds(0.175f);
        narrador = "que lasti";
        yield return new WaitForSeconds(0.175f);
        narrador = "que lastim";
        yield return new WaitForSeconds(0.175f);
        narrador = "que lastima";
        yield return new WaitForSeconds(0.175f);
        stopp = true;
    }
}
