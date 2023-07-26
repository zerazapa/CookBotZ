using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CheckVolume : MonoBehaviour
{
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
                if (string.IsNullOrEmpty(thirdLine))
                {
                    File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + "5\n" + fourthLine + "\n" + fifthLine + "\n" + sixthLine);
                    volumeLevel.volume = .5f;
                }
                else if (thirdLine == "0")
                {
                    volumeLevel.volume = 0f;
                }
                else if (thirdLine == "1")
                {
                    volumeLevel.volume = .1f;
                }
                else if (thirdLine == "2")
                {
                    volumeLevel.volume = .2f;
                }
                else if (thirdLine == "3")
                {
                    volumeLevel.volume = .3f;
                }
                else if (thirdLine == "4")
                {
                    volumeLevel.volume = .4f;
                }
                else if (thirdLine == "5")
                {
                    volumeLevel.volume = .5f;
                }
                else if (thirdLine == "6")
                {
                    volumeLevel.volume = .6f;
                }
                else if (thirdLine == "7")
                {
                    volumeLevel.volume = .7f;
                }
                else if (thirdLine == "8")
                {
                    volumeLevel.volume = .8f;
                }
                else if (thirdLine == "9")
                {
                    volumeLevel.volume = 1f;
                }
            }
        }
    }
}
