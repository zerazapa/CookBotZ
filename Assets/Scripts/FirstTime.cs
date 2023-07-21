using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class FirstTime : MonoBehaviour
{
    public static bool noHacerlo;
    public GameObject popupObject;

    private string filePath;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");
        
        if (File.Exists(filePath)) //si archivo existe
        {
            string content = File.ReadAllText(filePath);
            if (content.Trim() == "1")
            {
                noHacerlo = true;
            } //si dice 1, hacerlo es verdadero
        }
        else // si archivo no existe, se crea el archivo para la proxima vez
        {
            noHacerlo = false;
            File.WriteAllText(filePath, "1");
        }

        if (noHacerlo)
        {
            SceneManager.LoadScene("menu");
        }
        else
        {
          //ienumerator para que aparezca de a poco
            popupObject.gameObject.SetActive(true);
        }
    }
}
