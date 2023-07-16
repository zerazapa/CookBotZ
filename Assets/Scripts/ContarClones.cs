using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContarClones : MonoBehaviour
{
    
    public static bool canSpawn = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int cloneCount = CountClones();

        if (cloneCount >= 6)
        {
            canSpawn = false;
        }else
        {
            canSpawn = true;
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
}
