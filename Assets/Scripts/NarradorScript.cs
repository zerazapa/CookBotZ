using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarradorScript : MonoBehaviour
{
    public static string narrador;
    public static bool stopp = true;
    bool hasEnded = false;
    TextMeshProUGUI textMeshProUGUI;
    
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        stopp = true;
        narrador = "";
    }

    void Update()
    {
        textMeshProUGUI.text = narrador;

        if (Score.youWin && !hasEnded)
        {
            hasEnded = true;
            StartCoroutine(WinText());
        }
        if (Score.youLoose && !hasEnded)
        {
            hasEnded = true;
            StartCoroutine(LooseText());
        }

    }

    IEnumerator WinText()
    {
        stopp = false;
        narrador = "f";
        yield return new WaitForSeconds(0.1f);
        narrador = "fe";
        yield return new WaitForSeconds(0.1f);
        narrador = "fel";
        yield return new WaitForSeconds(0.1f);
        narrador = "feli";
        yield return new WaitForSeconds(0.1f);
        narrador = "felic";
        yield return new WaitForSeconds(0.1f);
        narrador = "felici";
        yield return new WaitForSeconds(0.1f);
        narrador = "felicid";
        yield return new WaitForSeconds(0.1f);
        narrador = "felicida";
        yield return new WaitForSeconds(0.1f);
        narrador = "felicidad";
        yield return new WaitForSeconds(0.1f);
        narrador = "felicidade";
        yield return new WaitForSeconds(0.1f);
        narrador = "felicidades";
        yield return new WaitForSeconds(0.1f);
        stopp = true;
    }
    IEnumerator LooseText()
    {
        stopp = false;
        narrador = "q";
        yield return new WaitForSeconds(0.1f);
        narrador = "qu";
        yield return new WaitForSeconds(0.1f);
        narrador = "que";
        yield return new WaitForSeconds(0.1f);
        narrador = "que ";
        yield return new WaitForSeconds(0.1f);
        narrador = "que l";
        yield return new WaitForSeconds(0.1f);
        narrador = "que la";
        yield return new WaitForSeconds(0.1f);
        narrador = "que las";
        yield return new WaitForSeconds(0.1f);
        narrador = "que last";
        yield return new WaitForSeconds(0.1f);
        narrador = "que lasti";
        yield return new WaitForSeconds(0.1f);
        narrador = "que lastim";
        yield return new WaitForSeconds(0.1f);
        narrador = "que lastima";
        yield return new WaitForSeconds(0.1f);
        stopp = true;
    }
}
