using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSettings : MonoBehaviour
{
    bool pressed = false;
    public GameObject ob1;
    GameObject ob2;
    GameObject ob3;
    GameObject ob4;
    GameObject ob5;
    GameObject ob6;
    GameObject ob7;
    Animator a1;
    Animator a2;
    Animator a3;
    Animator a4;
    Animator a5;
    Animator a6;
    Animator a7;

    public void Start()
    {
        ob1 = GameObject.Find("play");
        ob2 = GameObject.Find("prac");
        ob3 = GameObject.Find("tut");
        ob4 = GameObject.Find("logo");
        ob5 = GameObject.Find("stats");
        ob6 = GameObject.Find("cred");
        ob7 = GameObject.Find("exit");
        a1 = ob1.GetComponent<Animator>();
        a2 = ob2.GetComponent<Animator>();
        a3 = ob3.GetComponent<Animator>();
        a4 = ob4.GetComponent<Animator>();
        a5 = ob5.GetComponent<Animator>();
        a6 = ob6.GetComponent<Animator>();
        a7 = ob7.GetComponent<Animator>();
    }

    public void Click()
    {
        if (!pressed)
        {
            LeanTween.moveLocal(gameObject, new Vector2(0, 435), .75f).setEaseInOutCirc();
            pressed = true;
            DissapearEm();
        }
        else
        {
            LeanTween.moveLocal(gameObject, new Vector2(326.2209f, -396.8312f), .75f).setEaseInOutCirc();
            pressed = false;
            AppearEm();
        }
    }

    void DissapearEm()
    {
        a1.SetBool("dis", true);
        a2.SetBool("dis", true);
        a3.SetBool("dis", true);
        a4.SetBool("dis", true);
        a5.SetBool("dis", true);
        a6.SetBool("dis", true);
        a7.SetBool("dis", true);
    }

    void AppearEm()
    {
        a1.SetBool("dis", false);
        a2.SetBool("dis", false);
        a3.SetBool("dis", false);
        a4.SetBool("dis", false);
        a5.SetBool("dis", false);
        a6.SetBool("dis", false);
        a7.SetBool("dis", false);
    }
}
