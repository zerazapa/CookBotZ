using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    public TableScript tableScript;
    public int puntaje = 0; 
    
    TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        GameObject tableObject = GameObject.FindGameObjectWithTag("table");
        tableScript = tableObject.GetComponent<TableScript>();
    }

    void Update()
    {
        puntaje = TableScript.points;

        string scoreString = puntaje.ToString();

        textMeshProUGUI.text = scoreString;
    }
}
