using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class Score : MonoBehaviour
{
    
    public TableScript tableScript;
    public int puntaje = 0;
    public GameObject pScore;
    public GameObject eScore; 
    public Image scDisplay;
    public Image escDisplay;
    public Sprite sc1;
    public Sprite sc2;
    public Sprite sc3;
    public Sprite sc4;
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

        if (SceneManager.GetActiveScene().name == "practice")
        {
            pScore.SetActive(false);
        }
        if (SceneManager.GetActiveScene().name != "nv3")
        {
            eScore.SetActive(false);
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

        if (DishToDo.score == 1)
        {
            pScore.GetComponent<Image>().sprite = sc1;
        }
        else if (DishToDo.score == 2)
        {
            pScore.GetComponent<Image>().sprite = sc2;
        }
        else if (DishToDo.score == 3)
        {
            pScore.GetComponent<Image>().sprite = sc3;
        }
        else if (DishToDo.score == 4)
        {
            pScore.GetComponent<Image>().sprite = sc4;
            StartCoroutine(Finish());
        }
    }

    IEnumerator Finish()
    {
        Timer.isGameOver = true;
        yield return new WaitForSeconds(2f);
        BController.isPaused = true;
    }
}
