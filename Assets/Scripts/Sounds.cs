using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public Dictionary<char, AudioSource> sonidos = new Dictionary<char, AudioSource>();
    public AudioSource src;
    public AudioClip a,b,c,e,f,g,h,i,j,k,l,m,n,nn,o,p,q,r,s,t,u,v,w,y,z;
    public char ultimaLetra;

    public bool canChange = true;

    void Start()
    {
    }

    void Update()
    {
        if (NarradorScript.narrador != null)
        {
            string narrador = NarradorScript.narrador;
            ultimaLetra = narrador[narrador.Length - 1];
            if (!NarradorScript.stopp)
            {
                StartCoroutine(WaitingNChecking());
            }
        }
    }

    IEnumerator PlaySound()
    {
            if (ultimaLetra == 'A')
            {
                src.clip = a;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'B')
            {
                src.clip = b;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'C')
            {
                src.clip = c;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'D')
            {
                src.clip = b;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'E')
            {
                src.clip = e;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'F')
            {
                src.clip = f;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'G')
            {
                src.clip = g;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'H')
            {
                src.clip = h;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'I')
            {
                src.clip = i;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'J')
            {
                src.clip = j;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'K')
            {
                src.clip = k;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'L')
            {
                src.clip = l;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'M')
            {
                src.clip = m;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'N')
            {
                src.clip = n;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'Ñ')
            {
                src.clip = nn;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'O')
            {
                src.clip = o;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'P')
            {
                src.clip = p;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'Q')
            {
                src.clip = q;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'R')
            {
                src.clip = r;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'S')
            {
                src.clip = s;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'T')
            {
                src.clip = t;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'U')
            {
                src.clip = u;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'V')
            {
                src.clip = v;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'W')
            {
                src.clip = w;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'X')
            {
                src.clip = s;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'Y')
            {
                src.clip = y;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'Z')
            {
                src.clip = z;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
    }

    IEnumerator WaitingNChecking()
    {
        if(canChange)
        {
            canChange = false;
            StartCoroutine(PlaySound());
            yield return new WaitForSeconds(0.175f);
            canChange = true;
        }
    }
}