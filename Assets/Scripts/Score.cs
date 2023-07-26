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
    public static bool youWin;
    public static bool youLoose;
    public static bool endForTime;

    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        GameObject tableObject = GameObject.FindGameObjectWithTag("table");
        tableScript = tableObject.GetComponent<TableScript>();

        youWin = false;
        youLoose = false;
        endForTime = false;

        if (Timer.isStarting)
        {
            DishToDo.points = 0;
        }

        if (SceneManager.GetActiveScene().name == "practice" || Timer.estaescena == "tuto")
        {
            pScore.SetActive(false);
            textMeshProUGUI.enabled = false;
        }
        if (SceneManager.GetActiveScene().name != "nv3")
        {
            eScore.SetActive(false);
        }
        
        
    }

    void Update()
    {
        if (NarradorScript.appearScore)
        {
            textMeshProUGUI.enabled = true;
        }
        
        puntaje = DishToDo.points;

        string scoreString = puntaje.ToString();

        if (textMeshProUGUI != null)
        {
            if (textMeshProUGUI.gameObject.name == "score" || textMeshProUGUI.gameObject.name == "finalscore")
            {
                textMeshProUGUI.text = scoreString;
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
            StartCoroutine(Ending());
        }

        if (DishToDo.escore == 4)
        {
            StartCoroutine(Ending());
        }

        if (endForTime || !ContarClones.canSpawn1)
        {
            StartCoroutine(Ending());
        }
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(.75f);
        if (DishToDo.score == 4)
        {
            StartCoroutine(Win());
        }
        else if (DishToDo.escore == 4 || endForTime || !ContarClones.canSpawn1)
        {
            StartCoroutine(Loose());
        }
        
    }
    IEnumerator Win()
    {
        Timer.isGameOver = true;
        youWin = true;
        yield return new WaitForSeconds(3.5f);
        BController.isPaused = true;
    }
    IEnumerator Loose()
    {
        Timer.isGameOver = true;
        youLoose = true;
        yield return new WaitForSeconds(3.5f);
        BController.isPaused = true;
    }
}
