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

        
        if (Timer.isStarting)
        {
            DishToDo.points = 0;
        }

        if (gameObject.name == "points_p")
        {
            if (SceneManager.GetActiveScene().name == "practice")
            {
                gameObject.SetActive(false);
            }
        }
        if (gameObject.name == "points_e")
        {
            if (SceneManager.GetActiveScene().name != "nv3")
            {
                gameObject.SetActive(false);
            }
        }
        
    }

    void Update()
    {
        puntaje = DishToDo.points;

        string scoreString = puntaje.ToString();

        if (textMeshProUGUI != null)
        {
            if (textMeshProUGUI.gameObject.name == "score" || textMeshProUGUI.gameObject.name == "finalscore")
            {
                textMeshProUGUI.text = scoreString;
            }
        }
        
        if (textMeshProUGUI != null)
        {
            if (Timer.isGameOver && textMeshProUGUI.gameObject.name == "gameover")
            {
                textMeshProUGUI.gameObject.SetActive(true);
            }
        }
    }
}
