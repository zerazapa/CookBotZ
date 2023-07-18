using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarradorScript : MonoBehaviour
{
    public static string narrador;
    public static bool texto1 = true;
    public static bool stopp = true;
    TextMeshProUGUI textMeshProUGUI;
    
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (texto1)
        {
            StartCoroutine(Texto1());
        }

        textMeshProUGUI.text = narrador;

    }

    IEnumerator Texto1()
    {
        yield return new WaitForSeconds(3f);
        stopp = false;
        narrador = "B";
        yield return new WaitForSeconds(0.175f);
        narrador = "BU";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUE";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN ";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN I";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN IN";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN INT";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN INTE";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN INTEN";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN INTENT";
        yield return new WaitForSeconds(0.175f);
        narrador = "BUEN INTENTO";
        yield return new WaitForSeconds(0.175f);
        stopp = true;
    }
}
