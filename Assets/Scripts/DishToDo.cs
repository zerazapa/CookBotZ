using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DishToDo : MonoBehaviour
{
    public static int actualDish;

    public Sprite d1c;
    public Sprite d2c;
    public Sprite d3c;
    public Sprite d4c;
    public Sprite d5c;
    public Sprite d6c;
    public Sprite d7c;
    public Sprite d1o;
    public Sprite d2o;
    public Sprite d3o;
    public Sprite d4o;
    public Sprite d5o;
    public Sprite d6o;
    public Sprite d7o;
    public Image display;
    public static int points;
    public static int score;
    public static int escore;
    public static bool didRight = false;
    public static bool didWrong = false;

    void Start()
    {
        score = 0;
        escore = 0;
        actualDish = 0;
        didWrong = false;

        if (Timer.estaescena != "tuto")
        {
            RandomNewPlate();
        }
        else
        {
            display.enabled = false;
        }
        string filePath = Path.Combine(Application.persistentDataPath, "data.txt");

        using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                string secondLine = reader.ReadLine();
                string thirdLine = reader.ReadLine();
                string fourthLine = reader.ReadLine();
                string fifthLine = reader.ReadLine();
                reader.Close();
                if (fifthLine == "1")
                {
                    helpAlways.alwaysActive = true;
                }
                else if (fifthLine == "0")
                {
                    helpAlways.alwaysActive = false;
                }
            }
        
    }

    void Update()
    {
        if (TableScript.showingResultPlate)
        {
            ChangePoints();
        }
        ChangeImage();

        if (NarradorScript.appearRecipe)
        {
            FirstPlate();
        }
    }

    void FirstPlate()
    {
        actualDish = 1;
        display.enabled = true;
    }

    void RandomNewPlate()
    {
        int randomNumber = Random.Range(1, 8);
        if (randomNumber != actualDish)
        {
            actualDish = randomNumber;
        }
        else
        {
            RandomNewPlate();
        }
    }

    void ChangeImage()
    {
        if (actualDish == 1)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d1o;
            }
            else
            {
                display.sprite = d1c;
            }
        }
        if (actualDish == 2)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d2o;
            }
            else
            {
                display.sprite = d2c;
            }
        }
        if (actualDish == 3)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d3o;
            }
            else
            {
                display.sprite = d3c;
            }
        }
        if (actualDish == 4)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d4o;
            }
            else
            {
                display.sprite = d4c;
            }
        }
        if (actualDish == 5)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d5o;
            }
            else
            {
                display.sprite = d5c;
            }
        }
        if (actualDish == 6)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d6o;
            }
            else
            {
                display.sprite = d6c;
            }
        }
        if (actualDish == 7)
        {
            if (helpAlways.alwaysActive || Input.GetKey(KeyCode.Tab))
            {
                display.sprite = d7o;
            }
            else
            {
                display.sprite = d7c;
            }
        }
    }
    
    void ChangePoints()
    {
        TableScript.showingResultPlate = false;
        if (TableScript.dishDone == actualDish)
        {
            if (actualDish == 1)
            {
                points += 300;
                score += 1;
            }
            else if (actualDish == 2)
            {
                points += 300;
                score += 1;
            }
            else if (actualDish == 3)
            {
                points += 100;
                score += 1;
            }
            else if (actualDish == 4)
            {
                points += 300;
                score += 1;
            }
            else if (actualDish == 5)
            {
                points += 200;
                score += 1;
            }
            else if (actualDish == 6)
            {
                points += 200;
                score += 1;
            }
            else if (actualDish == 7)
            {
                points += 300;
                score += 1;
            }                
        }
        else
        {
            if (points >= 150)
            {
                points = points - 150;
            }
        }
        RandomNewPlate();
    }
}
