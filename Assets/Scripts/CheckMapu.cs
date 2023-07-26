using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class CheckMapu : MonoBehaviour
{
    string filePath;
    string firstLine;
    string secondLine;
    string thirdLine;
    string fourthLine;
    string fifthLine;
    string sixthLine;
    bool rewrite;
    
    bool mIsPressed;
    bool aIsPressed;
    bool pIsPressed;
    bool uIsPressed;
    bool mapuIsPressed;
    public static bool mapuLogro = false;

    public Sprite img1;
    public Sprite img2;
    private Image buttonImage;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.txt");
        firstLine = "";
        secondLine = "";
        thirdLine = "";
        fourthLine = "";
        fifthLine = "";
        sixthLine = "";
        mapuIsPressed = false;
    
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
                if (string.IsNullOrEmpty(sixthLine))
                {
                    File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + thirdLine + "\n" + fourthLine + "\n" + fifthLine + "\n0");
                    mapuLogro = false;
                }
                else if (sixthLine == "0")
                {
                    mapuLogro = false;
                }
                else if (sixthLine == "1")
                {
                    mapuLogro = true;
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "menu")
        {
            buttonImage = GetComponent<Image>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(MPressed());
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(APressed());
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(PPressed());
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(UPressed());
        }
        if (mIsPressed && aIsPressed && pIsPressed && uIsPressed)
        {
            mapuIsPressed = true;
        }

        if (mapuIsPressed)
        {
            mapuLogro = true;
            File.WriteAllText(filePath, firstLine + "\n" + secondLine + "\n" + thirdLine + "\n" + fourthLine + "\n" + fifthLine + "\n1");
        }

        if (SceneManager.GetActiveScene().name == "menu" && gameObject.name == "logroMapu")
        {
            if (!mapuLogro)
            {
                buttonImage.sprite = img1;
            }
            else
            {
                buttonImage.sprite = img2;
            }
        }
    }
    IEnumerator MPressed()
    {
        mIsPressed = true;
        aIsPressed = false;
        pIsPressed = false;
        uIsPressed = false;
        StopCoroutine(APressed());
        StopCoroutine(PPressed());
        StopCoroutine(UPressed());
        yield return new WaitForSeconds(1f);
        if (!Input.GetKey(KeyCode.M))
        {
            mIsPressed = false;
        }
    }
    IEnumerator APressed()
    {
        aIsPressed = true;
        pIsPressed = false;
        uIsPressed = false;
        StopCoroutine(PPressed());
        StopCoroutine(UPressed());
        yield return new WaitForSeconds(1f);
        if (!Input.GetKey(KeyCode.A))
        {
            aIsPressed = false;
        }
    }
    IEnumerator PPressed()
    {
        pIsPressed = true;
        uIsPressed = false;
        StopCoroutine(UPressed());
        yield return new WaitForSeconds(1f);
        if (!Input.GetKey(KeyCode.P))
        {
            pIsPressed = false;
        }
    }
    IEnumerator UPressed()
    {
        uIsPressed = true;
        yield return new WaitForSeconds(1f);
        if (!Input.GetKey(KeyCode.U))
        {
            uIsPressed = false;
        }
    }
}
