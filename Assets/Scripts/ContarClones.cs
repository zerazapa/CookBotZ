using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContarClones : MonoBehaviour
{   
    public static bool canSpawn = true;

    Image imageComponent;
    public Sprite sinUsar;
    public Sprite usado;
    public Sprite perdido;

    public static bool canSpawn2 = true;
    public static bool canSpawn3 = true;
    public static bool canSpawn4 = true;
    public static bool canSpawn5 = true;
    public static bool canSpawn6 = true;

    void Start()
    {
        imageComponent = GetComponent<Image>();
        canSpawn2 = true;
        canSpawn3 = true;
        canSpawn4 = true;
        canSpawn5 = true;
        canSpawn6 = true;
    }

    void Update()
    {
        int cloneCount = CountClones();

        if (cloneCount == 0)
        {
            canSpawn = true;
        }
        if (cloneCount == 1)
        {
            if (!canSpawn2)
            {
                canSpawn = false;
            }
            else
            {
                canSpawn = true;
            }
        }
        if (cloneCount == 2)
        {
            if (!canSpawn3)
            {
                canSpawn = false;
            }
            else
            {
                canSpawn = true;
            }
        }
        if (cloneCount == 3)
        {
            if (!canSpawn4)
            {
                canSpawn = false;
            }
            else
            {
                canSpawn = true;
            }
        }
        if (cloneCount == 4)
        {
            if (!canSpawn5)
            {
                canSpawn = false;
            }
            else
            {
                canSpawn = true;
            }
        }
        if (cloneCount == 5)
        {
            if (!canSpawn6)
            {
                canSpawn = false;
            }
            else
            {
                canSpawn = true;
            }
        }


        if (cloneCount > 0 && gameObject.name == "spot (1)")
        {
            imageComponent.sprite = usado;
        }
        if (cloneCount > 1 && gameObject.name == "spot (2)")
        {
            imageComponent.sprite = usado;
        }
        if (cloneCount > 2 && gameObject.name == "spot (3)")
        {
            imageComponent.sprite = usado;
        }
        if (cloneCount > 3 && gameObject.name == "spot (4)")
        {
            imageComponent.sprite = usado;
        }
        if (cloneCount > 4 && gameObject.name == "spot (5)")
        {
            imageComponent.sprite = usado;
        }
        if (cloneCount > 5 && gameObject.name == "spot (6)")
        {
            imageComponent.sprite = usado;
        }

        if (cloneCount < 1 && gameObject.name == "spot (1)")
        {
            imageComponent.sprite = sinUsar;
        }
        if (cloneCount < 2 && gameObject.name == "spot (2)" && canSpawn2)
        {
            imageComponent.sprite = sinUsar;
        }
        if (cloneCount < 3 && gameObject.name == "spot (3)" && canSpawn3)
        {
            imageComponent.sprite = sinUsar;
        }
        if (cloneCount < 4 && gameObject.name == "spot (4)" && canSpawn4)
        {
            imageComponent.sprite = sinUsar;
        }
        if (cloneCount < 5 && gameObject.name == "spot (5)" && canSpawn5)
        {
            imageComponent.sprite = sinUsar;
        }
        if (cloneCount < 6 && gameObject.name == "spot (6)" && canSpawn6)
        {
            imageComponent.sprite = sinUsar;
        }

        if (!canSpawn6 && gameObject.name == "spot (6)")
        {
            imageComponent.sprite = perdido;
        }
        if (!canSpawn5 && gameObject.name == "spot (5)")
        {
            imageComponent.sprite = perdido;
        }
        if (!canSpawn4 && gameObject.name == "spot (4)")
        {
            imageComponent.sprite = perdido;
        }
        if (!canSpawn3 && gameObject.name == "spot (3)")
        {
            imageComponent.sprite = perdido;
        }
        if (!canSpawn2 && gameObject.name == "spot (2)")
        {
            imageComponent.sprite = perdido;
        }
        if (BController.isGameOver && gameObject.name == "spot (1)")
        {
            imageComponent.sprite = perdido;
        }

    }

    int CountClones()
    {
        int count = 0;

        count += CountClonesWithName("Dish(Clone)");
        count += CountClonesWithName("Bread1(Clone)");
        count += CountClonesWithName("Bread2(Clone)");
        count += CountClonesWithName("Meat(Clone)");
        count += CountClonesWithName("Cheese(Clone)");
        count += CountClonesWithName("Lettuce(Clone)");

        return count;
    }

    int CountClonesWithName(string name)
    {
        GameObject[] clones = GameObject.FindObjectsOfType<GameObject>();

        int count = 0;
        foreach (GameObject clone in clones)
        {
            if (clone.name == name)
            {
                count++;
            }
        }

        return count;
    }

    public void ReduceCloneCount()
    {
        int cloneCount = CountClones();
        if (cloneCount > 0)
        {
            cloneCount--;
        }
    }
}
