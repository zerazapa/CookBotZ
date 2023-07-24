using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class volumeLevel : MonoBehaviour
{
    public Sprite off;
    public Sprite on;
    public Image barra1;
    public Image barra2;
    public Image barra3;
    public Image barra4;
    public Image barra5;
    public Image barra6;
    public Image barra7;
    public Image barra8;
    public Image barra9;
    public static float volume;
    string filePath;
    string firstLine;
    string secondLine;
    string thirdLine;
    string fourthLine;
    string fifthLine;
    bool rewrite;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");
        firstLine = "";
        secondLine = "";
        thirdLine = "";
        fourthLine = "";
        fifthLine = "";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                firstLine = reader.ReadLine();
                secondLine = reader.ReadLine();
                thirdLine = reader.ReadLine();
                fourthLine = reader.ReadLine();
                fifthLine = reader.ReadLine();
                reader.Close();
                if (string.IsNullOrEmpty(thirdLine))
                {
                    File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "5\n" + fourthLine + "\n" + fifthLine);
                }
                else if (thirdLine == "0")
                {
                    volume = 0f;
                }
                else if (thirdLine == "1")
                {
                    volume = .1f;
                }
                else if (thirdLine == "2")
                {
                    volume = .2f;
                }
                else if (thirdLine == "3")
                {
                    volume = .3f;
                }
                else if (thirdLine == "4")
                {
                    volume = .4f;
                }
                else if (thirdLine == "5")
                {
                    volume = .5f;
                }
                else if (thirdLine == "6")
                {
                    volume = .6f;
                }
                else if (thirdLine == "7")
                {
                    volume = .7f;
                }
                else if (thirdLine == "8")
                {
                    volume = .8f;
                }
                else if (thirdLine == "9")
                {
                    volume = 1f;
                }
            }
        }
    }
    public void VolumeUp()
    {
        rewrite = true;
        if (volume == 0.8f)
        {
            volume = 1f;
        }
        else if (volume == 0.7f)
        {
            volume = 0.8f;
        }
        else if (volume == 0.6f)
        {
            volume = 0.7f;
        }
        else if (volume == 0.5f)
        {
            volume = 0.6f;
        }
        else if (volume == 0.4f)
        {
            volume = 0.5f;
        }
        else if (volume == 0.3f)
        {
            volume = 0.4f;
        }
        else if (volume == 0.2f)
        {
            volume = 0.3f;
        }
        else if (volume == 0.1f)
        {
            volume = 0.2f;
        }
        else if (volume == 0f)
        {
            volume = 0.1f;
        }
    }

    public void VolumeDown()
    {
        rewrite = true;
        if (volume == 1f)
        {
            volume = 0.8f;
        }
        else if (volume == 0.8f)
        {
            volume = 0.7f;
        }
        else if (volume == 0.7f)
        {
            volume = 0.6f;
        }
        else if (volume == 0.6f)
        {
            volume = 0.5f;
        }
        else if (volume == 0.5f)
        {
            volume = 0.4f;
        }
        else if (volume == 0.4f)
        {
            volume = 0.3f;
        }
        else if (volume == 0.3f)
        {
            volume = 0.2f;
        }
        else if (volume == 0.2f)
        {
            volume = 0.1f;
        }
        else if (volume == 0.1f)
        {
            volume = 0f;
        }
    }

    void Update()
    {
        Debug.Log(volume);
        if (rewrite)
        {
            if (volume == 0f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "0\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .1f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "1\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .2f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "2\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .3f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "3\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .4f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "4\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .5f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "5\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .6f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "6\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .7f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "7\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == .8f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "8\n" + fourthLine + "\n" + fifthLine);
            }
            else if (volume == 1f)
            {
                File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "9\n" + fourthLine + "\n" + fifthLine);
            }
            rewrite = false;
        }

        if (volume == 0f)
        {
            barra1.sprite = off;
            barra2.sprite = off;
            barra3.sprite = off;
            barra4.sprite = off;
            barra5.sprite = off;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.1f)
        {
            barra1.sprite = on;
            barra2.sprite = off;
            barra3.sprite = off;
            barra4.sprite = off;
            barra5.sprite = off;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.2f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = off;
            barra4.sprite = off;
            barra5.sprite = off;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.3f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = off;
            barra5.sprite = off;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.4f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = off;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.5f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = on;
            barra6.sprite = off;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.6f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = on;
            barra6.sprite = on;
            barra7.sprite = off;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.7f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = on;
            barra6.sprite = on;
            barra7.sprite = on;
            barra8.sprite = off;
            barra9.sprite = off;
        }
        if (volume == 0.8f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = on;
            barra6.sprite = on;
            barra7.sprite = on;
            barra8.sprite = on;
            barra9.sprite = off;
        }
        if (volume == 1f)
        {
            barra1.sprite = on;
            barra2.sprite = on;
            barra3.sprite = on;
            barra4.sprite = on;
            barra5.sprite = on;
            barra6.sprite = on;
            barra7.sprite = on;
            barra8.sprite = on;
            barra9.sprite = on;
        }
        
    }
}
