using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    public Transform place3;
    public Transform place4;
    public Transform place5;
    public Transform place6;
    public static bool place1used = false;
    public static bool place2used = false;
    public static bool place3used = false;
    public static bool place4used = false;
    public static bool place5used = false;
    public static bool place6used = false;
    
    public  bool lugar1dish = false;
    public  bool lugar2bread1 = false;
    public  bool lugar3meat = false;
    public  bool lugar3cheese = false;
    public  bool lugar3lettuce = false;
    public  bool lugar3bread2 = false;
    public  bool lugar4meat= false;
    public  bool lugar4cheese = false;
    public  bool lugar4lettuce = false;
    public  bool lugar4bread2 = false;
    public  bool lugar5meat = false;
    public  bool lugar5cheese = false;
    public  bool lugar5lettuce = false;
    public  bool lugar5bread2 = false;
    public  bool lugar6bread2 = false;
    public  bool showingResultPlate = false; 

    public GameObject helpd;
    public GameObject helpb1;
    public GameObject helpb21;
    public GameObject helpb22;
    public GameObject helpb23;
    public GameObject helpb24;
    public GameObject ejemplo1;
    public GameObject ejemplo2;
    public GameObject ejemplo3;
    public GameObject ejemplo4;
    public GameObject ejemplo5;
    public GameObject ejemplo6;
    public GameObject ejemplo7;
    public GameObject ejemplomalo;

    Transform child1 = null;
    Transform child2 = null;
    Transform child3 = null;
    Transform child4 = null;
    Transform child5 = null;
    Transform child6 = null;

    public static int points = 0;

    void Start()
    {
        place1 = GameObject.Find("place1").transform;
        place2 = GameObject.Find("place2").transform;
        place3 = GameObject.Find("place3").transform;
        place4 = GameObject.Find("place4").transform;
        place5 = GameObject.Find("place5").transform;
        place6 = GameObject.Find("place6").transform;

        helpd = GameObject.Find("helpd");
        helpb1 = GameObject.Find("helpb1");
        helpb21 = GameObject.Find("helpb21");
        helpb22 = GameObject.Find("helpb22");
        helpb23 = GameObject.Find("helpb23");
        helpb24 = GameObject.Find("helpb24");
        ejemplo1 = GameObject.Find("ejemplo1");
        ejemplo2 = GameObject.Find("ejemplo2");
        ejemplo3 = GameObject.Find("ejemplo3");
        ejemplo4 = GameObject.Find("ejemplo4");
        ejemplo5 = GameObject.Find("ejemplo5");
        ejemplo6 = GameObject.Find("ejemplo6");
        ejemplo7 = GameObject.Find("ejemplo7");
        ejemplomalo = GameObject.Find("ejemplomalo");
    }

    void Update()
    {
        if (!place1used)
        {
                place2used = false;
                place3used = false;
                place4used = false;
                place5used = false;
                place6used = false;
            }
            if (!place2used)
            {
                place3used = false;
                place4used = false;
                place5used = false;
                place6used = false;
            }
            if (!place3used)
            {
                place4used = false;
                place5used = false;
                place6used = false;
            }
            if (!place4used)
            {
                place5used = false;
                place6used = false;
            }
            if (!place5used)
            {
                place6used = false;
        }

        if (place1.transform.childCount == 2)
        {
                place1used = true;
            }
            else
            {
                place1used = false;
            }
            if (place2.transform.childCount == 2)
            {
                place2used = true;
            }
            else
            {
                place2used = false;
            }
            if (place3.transform.childCount == 2)
            {
                place3used = true;
            }
            else
            {
                place3used = false;
            }
            if (place4.transform.childCount == 2)
            {
                place4used = true;
            }
            else
            {
                place4used = false;
            }
            if (place5.transform.childCount == 2)
            {
                place5used = true;
            }
            else
            {
                place5used = false;
            }
            if (place6.transform.childCount == 2)
            {
                place6used = true;
            }
            else
            {
                place6used = false;
        }

        if (place1.childCount > 1)
        {
            child1 = place1.GetChild(1);
            if (child1.CompareTag("tDish"))
            {
                lugar1dish = true;
            }
            else
            {
                lugar1dish = false;
            }
        } else
        {
            child1 = null;
        }

        if (place2.childCount > 1)
        {
            child2 = place2.GetChild(1);
            if (child2.CompareTag("tBread1"))
            {
                lugar2bread1 = true;
            }
            else
            {
                lugar2bread1 = false;
            }
        } else
        {
            child2 = null;
        }

        if (place3.childCount > 1)
        {
            child3 = place3.GetChild(1);
            if (child3.CompareTag("tMeat"))
            {
                    lugar3meat = true;
                }
                else
                {
                    lugar3meat = false;
            }
            if (child3.CompareTag("tCheese"))
            {
                    lugar3cheese = true;
                }
                else
                {
                    lugar3cheese = false;
            }
            if (child3.CompareTag("tLettuce"))
            {
                    lugar3lettuce = true;
                }
                else
                {
                    lugar3lettuce = false;
            }
            if (child3.CompareTag("tBread2"))
            {
                    lugar3bread2 = true;
                }
                else
                {
                    lugar3bread2 = false;
            }
        } else
        {
            child3 = null;
        }

        if (place4.childCount > 1)
        {
            child4 = place4.GetChild(1);
            if (child4.CompareTag("tMeat"))
            {
                    lugar4meat = true;
                }
                else
                {
                    lugar4meat = false;
            }
            if (child4.CompareTag("tCheese"))
            {
                    lugar4cheese = true;
                }
                else
                {
                    lugar4cheese = false;
            }
            if (child4.CompareTag("tLettuce"))
            {
                    lugar4lettuce = true;
                }
                else
                {
                    lugar4lettuce = false;
            }
            if (child4.CompareTag("tBread2"))
            {
                    lugar4bread2 = true;
                }
                else
                {
                    lugar4bread2 = false;
            }
        } else
        {
            child4 = null;
        }

        if (place5.childCount > 1)
        {
            child5 = place5.GetChild(1);
            if (child5.CompareTag("tMeat"))
            {
                    lugar5meat = true;
                }
                else
                {
                    lugar5meat = false;
            }
            if (child5.CompareTag("tCheese"))
            {
                    lugar5cheese = true;
                }
                else
                {
                    lugar5cheese = false;
            }
            if (child5.CompareTag("tLettuce"))
            {
                    lugar5lettuce = true;
                }
                else
                {
                    lugar5lettuce = false;
            }
            if (child5.CompareTag("tBread2"))
            {
                    lugar5bread2 = true;
                }
                else
                {
                    lugar5bread2 = false;
            }
        } else
        {
            child5 = null;
        }

        if (place6.childCount > 1)
        {
            child6 = place6.GetChild(1);
            if (child6.CompareTag("tBread2"))
            {
                    lugar6bread2 = true;
                }
                else
                {
                    lugar6bread2 = false;
            }
        } else
        {
            child6 = null;
        }

        if ((lugar1dish && lugar2bread1 && lugar3meat && lugar4cheese && lugar5lettuce && lugar6bread2) && (child6 != null)) //full
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            Destroy(child6.gameObject);
            //if dishmade == dishasked {showresult}
            StartCoroutine(ShowResult1());
        }

        if ((lugar1dish && lugar2bread1 && lugar3cheese && lugar4cheese && lugar5cheese && lugar6bread2) && (child6 != null)) //3cheese
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            Destroy(child6.gameObject);
            
            StartCoroutine(ShowResult2());
        }

        if ((lugar1dish && lugar2bread1 && lugar3meat && lugar4bread2) && (child4 != null)) //1meat
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            
            StartCoroutine(ShowResult3());
        }

        if ((lugar1dish && lugar2bread1 && lugar3meat && lugar4cheese && lugar5meat && lugar6bread2) && (child6 != null)) //meat cheese meat
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            Destroy(child6.gameObject);
            
            StartCoroutine(ShowResult4());
        }

        if ((lugar1dish && lugar2bread1 && lugar3meat && lugar4lettuce && lugar5bread2) && (child5 != null)) //meat lettuce
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            
            StartCoroutine(ShowResult5());
        }

        if ((lugar1dish && lugar2bread1 && lugar3meat && lugar4cheese && lugar5bread2) && (child5 != null)) //meat cheese
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            
            StartCoroutine(ShowResult6());
        }

        if ((lugar1dish && lugar2bread1 && lugar3lettuce && lugar4meat && lugar5lettuce && lugar6bread2) && (child6 != null)) //let mea let
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            Destroy(child6.gameObject);
            
            StartCoroutine(ShowResult7());
        }

        if ((lugar1dish && lugar2bread1 && lugar3bread2) && (child3 != null))
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            
            StartCoroutine(ShowResultWrong());
        }

        if ((lugar1dish && lugar2bread1 && lugar4bread2) && (child4 != null))
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            
            StartCoroutine(ShowResultWrong());
        }

        if ((lugar1dish && lugar2bread1 && lugar5bread2) && (child5 != null))
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            
            StartCoroutine(ShowResultWrong());
        }

        if ((lugar1dish && lugar2bread1 && !lugar3meat && !lugar4cheese && !lugar5lettuce && lugar6bread2) && (child6 != null))
        {
            Destroy(child1.gameObject);
            Destroy(child2.gameObject);
            Destroy(child3.gameObject);
            Destroy(child4.gameObject);
            Destroy(child5.gameObject);
            Destroy(child6.gameObject);
            
            StartCoroutine(ShowResultWrong());
        }

         if (place1.transform.childCount == 1 && !showingResultPlate)
        {
                helpd.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpd.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (place2.transform.childCount == 1 && !showingResultPlate)
            {
                helpb1.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpb1.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (place3.transform.childCount == 1 && !showingResultPlate)
            {
                helpb21.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpb21.GetComponent<SpriteRenderer>().enabled = true;
            }
            if (place4.transform.childCount == 1 && place3.transform.childCount == 2)
            {
                helpb22.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpb22.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (place5.transform.childCount == 1 && place4.transform.childCount == 2)
            {
                helpb23.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpb23.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (place6.transform.childCount == 1 && place5.transform.childCount == 2)
            {
                helpb24.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                helpb24.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    IEnumerator ShowResult1()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo1.GetComponent<SpriteRenderer>().enabled = true;
        points += 300;
        yield return new WaitForSeconds(2f);
        ejemplo1.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult2()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo2.GetComponent<SpriteRenderer>().enabled = true;
        points += 300;
        yield return new WaitForSeconds(2f);
        ejemplo2.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult3()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo3.GetComponent<SpriteRenderer>().enabled = true;
        points += 100;
        yield return new WaitForSeconds(2f);
        ejemplo3.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult4()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo4.GetComponent<SpriteRenderer>().enabled = true;
        points += 300;
        yield return new WaitForSeconds(2f);
        ejemplo4.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult5()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo5.GetComponent<SpriteRenderer>().enabled = true;
        points += 200;
        yield return new WaitForSeconds(2f);
        ejemplo5.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult6()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo6.GetComponent<SpriteRenderer>().enabled = true;
        points += 200;
        yield return new WaitForSeconds(2f);
        ejemplo6.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResult7()
    {
        showingResultPlate = true;
        GrabNDrop.callDestroyed = true;
        ejemplo7.GetComponent<SpriteRenderer>().enabled = true;
        points += 300;
        yield return new WaitForSeconds(2f);
        ejemplo7.GetComponent<SpriteRenderer>().enabled = false;
        showingResultPlate = false;
    }

    IEnumerator ShowResultWrong()
    {
        if (!showingResultPlate)
        {
            showingResultPlate = true;
            GrabNDrop.callDestroyed = true;
            if (!ContarClones.canSpawn2)
            {
                    BController.isGameOver = true;
                }
                if (!ContarClones.canSpawn3)
                {
                    ContarClones.canSpawn2 = false;
                }
                if (!ContarClones.canSpawn4)
                {
                    ContarClones.canSpawn3 = false;
                }
                if (!ContarClones.canSpawn5)
                {
                    ContarClones.canSpawn4 = false;
                }
                if (!ContarClones.canSpawn6)
                {
                    ContarClones.canSpawn5 = false;
                }
                if (ContarClones.canSpawn6)
                {
                    ContarClones.canSpawn6 = false;
            }
            ejemplomalo.GetComponent<SpriteRenderer>().enabled = true;
            if (points > 0)
            {
                points -= 150;
            }
            yield return new WaitForSeconds(2f);
            ejemplomalo.GetComponent<SpriteRenderer>().enabled = false;
            showingResultPlate = false;
        }
    }
}
