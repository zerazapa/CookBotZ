using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (Timer.isStarting)
        {
            TableScript.points = 0;
        }
        
        puntaje = TableScript.points;

        string scoreString = puntaje.ToString();

        if (textMeshProUGUI != null)
        {
            if (textMeshProUGUI.gameObject.name == "score" || textMeshProUGUI.gameObject.name == "finalscore")
            {
                textMeshProUGUI.text = scoreString;
            }
        }
        
        if (Timer.isGameOver && textMeshProUGUI.gameObject.name == "gameover")
        {
            textMeshProUGUI.gameObject.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            if (gameObject.name == "points_p" || gameObject.name == "points_e")
            {
                gameObject.SetActive(false);
            }
        }
    }
}
