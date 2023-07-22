using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class fullScreen : MonoBehaviour
{
    public Sprite img1;
    public Sprite img2;
    private Image buttonImage;
    string filePath;
    string firstLine;
    string secondLine;
    bool rewrite;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");
        firstLine = "";
        secondLine = "";
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                firstLine = reader.ReadLine();
                secondLine = reader.ReadLine();
                reader.Close();
                if (string.IsNullOrEmpty(secondLine))
                {
                    File.WriteAllText(filePath, firstLine + "\n" + "0");
                }
                else if (secondLine == "1")
                {
                    Screen.fullScreen = false;
                }
                else if (secondLine == "0")
                {
                    Screen.fullScreen = true;
                }
            }
        }
        buttonImage = GetComponent<Image>();
    }

    public void Click()
    {
        Screen.fullScreen = !Screen.fullScreen;
        rewrite = true;
    }

    void Update()
    {
        if (Screen.fullScreen)
        {
            buttonImage.sprite = img2;
        }
        else
        {
            buttonImage.sprite = img1;
        }
        if (rewrite)
        {
            if (Screen.fullScreen)
            {
                File.WriteAllText(filePath, firstLine + "\n" + "1");
            }
            else if (!Screen.fullScreen)
            {
                File.WriteAllText(filePath, firstLine + "\n" + "0");
            }
            rewrite = false;
        }
    }
}
