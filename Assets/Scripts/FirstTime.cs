using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class FirstTime : MonoBehaviour
{
    public static bool isFirstTime;
    public GameObject popupObject;

    private string filePath;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");

        if (File.Exists(filePath)) // Si archivo existe
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                if (firstLine == "1")
                {
                    isFirstTime = false;
                }
                else
                {
                    isFirstTime = true;
                }
            }
        }
        else // Si archivo no existe, se crea el archivo para la próxima vez
        {
            isFirstTime = true;
            File.WriteAllText(filePath, "1");
        }

        if (!isFirstTime)
        {
            SceneManager.LoadScene("menu");
        }
        else
        {
            // IEnumerator para que aparezca de a poco
            popupObject.gameObject.SetActive(true);
        }
    }
}
