using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BController1 : MonoBehaviour
{
    string nivel1 = "nv1";
    string menu = "menu";
    string tuto = "tuto";

    public GameObject popupObject;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            NarradorScript.texto1 = true;
        }
        else
        {
            NarradorScript.texto1 = false;
        }
    }

    public void OnYesClicked()
    {
        //hacer que aparezca el tutorial
        popupObject.gameObject.SetActive(false);
    }

    public void OnNoClicked()
    {
        //hacer que se vaya al menu
        SceneManager.LoadScene(menu);
    }
}
