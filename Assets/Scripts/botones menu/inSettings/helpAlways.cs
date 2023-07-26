using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class helpAlways : MonoBehaviour
{
    public Sprite img1;
    public Sprite img2;
    private Image buttonImage;
    public static bool alwaysActive;
    string filePath;
    string firstLine;
    string secondLine;
    string thirdLine;
    string fourthLine;
    string fifthLine;
    string sixthLine;
    bool rewrite;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");
        firstLine = "";
        secondLine = "";
        thirdLine = "";
        fourthLine = "";
        fifthLine = "";
        sixthLine = "";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                firstLine = reader.ReadLine();
                secondLine = reader.ReadLine();
                thirdLine = reader.ReadLine();
                fourthLine = reader.ReadLine();
                fifthLine = reader.ReadLine();
                sixthLine = reader.ReadLine();
                reader.Close();
                if (string.IsNullOrEmpty(fifthLine))
                {
                    File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + thirdLine + "\n" + fourthLine + "\n" + "1\n" + sixthLine);
                    alwaysActive = true;
                }
                else if (fifthLine == "1")
                {
                    alwaysActive = true;
                }
                else if (fifthLine == "0")
                {
                    alwaysActive = false;
                }
            }
        }

        buttonImage = GetComponent<Image>();
    }

    public void Click()
    {
        alwaysActive = !alwaysActive;
        rewrite = true;
    }

    void Update()
    {
        if (alwaysActive)
        {
            buttonImage.sprite = img2;
        }
        else
        {
            buttonImage.sprite = img1;
        }

        if (rewrite)
        {
            if (alwaysActive)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + thirdLine + "\n" + fourthLine + "\n" + "1\n" + sixthLine);
            }
            else if (!alwaysActive)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + thirdLine + "\n" + fourthLine + "\n" + "0\n" + sixthLine);
            }
            rewrite = false;
        }
    }
}
