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
        src = GetComponent<AudioSource>();
        a = Resources.Load<AudioClip>("a");
        b = Resources.Load<AudioClip>("b");
        c = Resources.Load<AudioClip>("c");
        e = Resources.Load<AudioClip>("e");
        f = Resources.Load<AudioClip>("f");
        g = Resources.Load<AudioClip>("g");
        h = Resources.Load<AudioClip>("h");
        i = Resources.Load<AudioClip>("i");
        j = Resources.Load<AudioClip>("j");
        k = Resources.Load<AudioClip>("k");
        l = Resources.Load<AudioClip>("l");
        m = Resources.Load<AudioClip>("m");
        n = Resources.Load<AudioClip>("n");
        nn = Resources.Load<AudioClip>("ñ");
        o = Resources.Load<AudioClip>("o");
        p = Resources.Load<AudioClip>("p");
        q = Resources.Load<AudioClip>("q");
        r = Resources.Load<AudioClip>("r");
        s = Resources.Load<AudioClip>("s");
        t = Resources.Load<AudioClip>("t");
        u = Resources.Load<AudioClip>("u");
        v = Resources.Load<AudioClip>("v");
        w = Resources.Load<AudioClip>("w");
        y = Resources.Load<AudioClip>("y");
        z = Resources.Load<AudioClip>("z");
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
            if (ultimaLetra == 'a')
            {
                src.clip = a;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'b')
            {
                src.clip = b;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'c')
            {
                src.clip = c;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'd')
            {
                src.clip = b;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'e')
            {
                src.clip = e;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'f')
            {
                src.clip = f;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'g')
            {
                src.clip = g;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'h')
            {
                src.clip = h;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'i')
            {
                src.clip = i;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'j')
            {
                src.clip = j;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'k')
            {
                src.clip = k;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'l')
            {
                src.clip = l;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'm')
            {
                src.clip = m;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'n')
            {
                src.clip = n;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == '+')
            {
                src.clip = nn;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'o')
            {
                src.clip = o;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'p')
            {
                src.clip = p;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'q')
            {
                src.clip = q;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'r')
            {
                src.clip = r;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 's')
            {
                src.clip = s;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 't')
            {
                src.clip = t;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'u')
            {
                src.clip = u;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'v')
            {
                src.clip = v;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'w')
            {
                src.clip = w;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'x')
            {
                src.clip = s;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'y')
            {
                src.clip = y;
                src.Play();
                yield return new WaitForSeconds(0.175f);
                src.Stop();
            }
            if (ultimaLetra == 'z')
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