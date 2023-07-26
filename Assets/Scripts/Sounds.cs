using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip felicidades, lastima, first, second, third, fourth, fifth;
    public AudioClip sixth, seventh, eighth, eighth2, nineth, tenth, eleventh, twelfth;
    public AudioClip thirteenth, fourteenth, fifteenth, sixteenth, seventeenth;
    public AudioClip eighteenth, nineteenth, twentieth, twentyfirst, twentysecond;
    public AudioClip twentythird, twentyfourth, twentyfifth, twentysixth;
    public AudioClip veintisiete, veintiocho, veintinueve, treinta;
    public AudioClip treintaiuno, treintaidos, treintaitres, treintaicuatro, treintaicinco;
    public AudioClip treintaiseis, treintaisiete, treintaiocho, treintainueve;

    bool isWinSoundPlayed = false;
    bool isLoseSoundPlayed = false;
    bool isFirstPlayed;
    bool isSecondPlayed;
    bool isThirdPlayed;
    bool isFourthPlayed;
    bool isFifhtPlayed;
    bool isSixthPlayed;
    bool isSeventhPlayed;
    bool isEighthPlayed;
    bool isEighth2Played;
    bool isNinethPlayed;
    bool isTenthPlayed;
    bool isEleventhPlayed;
    bool isTwelfthPlayed;
    bool isThirteenthPlayed;
    bool isFourteenthPlayed;
    bool isFifteenthPlayed;
    bool isSixteenthPlayed;
    bool isSeventeenthPlayed;
    bool isEighteenthPlayed;
    bool isNineteenthPlayed;
    bool isTwentiethPlayed;
    bool isTwentyfirstPlayed;
    bool isTwentysecondPlayed;
    bool isTwentythirdPlayed;
    bool isTwentyfourthPlayed;
    bool isTwentyfifthPlayed;
    bool isTwentysixthPlayed;
    bool isVeintisietePlayed;
    bool isVeintiochoPlayed;
    bool isVeintinuevePlayed;
    bool isTreintaPlayed;
    bool isTreintaiunoPlayed;
    bool isTreintaidosPlayed;
    bool isTreintaitresPlayed;
    bool isTreintaicuatroPlayed;
    bool isTreintaicincoPlayed;
    public static bool isTreintaiseisPlayed;
    public static bool isTreintaisietePlayed;
    public static bool isTreintaiochoPlayed;
    public static bool isTreintainuevePlayed;

    void Start()
    {
        src = GetComponent<AudioSource>();
        felicidades = Resources.Load<AudioClip>("goodending");
        lastima = Resources.Load<AudioClip>("badending");
        first = Resources.Load<AudioClip>("first");
        second = Resources.Load<AudioClip>("second");
        third = Resources.Load<AudioClip>("third");
        fourth = Resources.Load<AudioClip>("fourth");
        fifth = Resources.Load<AudioClip>("fifth");
        sixth = Resources.Load<AudioClip>("sixth");
        seventh = Resources.Load<AudioClip>("seventh");
        eighth = Resources.Load<AudioClip>("eighth");
        eighth2 = Resources.Load<AudioClip>("eighth2");
        nineth = Resources.Load<AudioClip>("nineth");
        tenth = Resources.Load<AudioClip>("tenth");
        eleventh = Resources.Load<AudioClip>("eleventh");
        twelfth = Resources.Load<AudioClip>("twelfth");
        thirteenth = Resources.Load<AudioClip>("thirteenth");
        fourteenth = Resources.Load<AudioClip>("fourteenth");
        fifteenth = Resources.Load<AudioClip>("fifteenth");
        sixteenth = Resources.Load<AudioClip>("sixteenth");
        seventeenth = Resources.Load<AudioClip>("seventeenth");
        eighteenth = Resources.Load<AudioClip>("eighteenth");
        nineteenth = Resources.Load<AudioClip>("nineteenth");
        twentieth = Resources.Load<AudioClip>("twentieth");
        twentyfirst = Resources.Load<AudioClip>("twentyfirst");
        twentysecond = Resources.Load<AudioClip>("twentysecond");
        twentythird = Resources.Load<AudioClip>("twentythird");
        twentyfourth = Resources.Load<AudioClip>("twentyfourth");
        twentyfifth = Resources.Load<AudioClip>("twentyfifth");
        twentysixth = Resources.Load<AudioClip>("twentysixth");
        veintisiete = Resources.Load<AudioClip>("veintisiete");
        veintiocho = Resources.Load<AudioClip>("veintiocho");
        veintinueve = Resources.Load<AudioClip>("veintinueve");
        treinta = Resources.Load<AudioClip>("treinta");
        treintaiuno = Resources.Load<AudioClip>("treintaiuno");
        treintaidos = Resources.Load<AudioClip>("treintaidos");
        treintaitres = Resources.Load<AudioClip>("treintaitres");
        treintaicuatro = Resources.Load<AudioClip>("treintaicuatro");
        treintaicinco = Resources.Load<AudioClip>("treintaicinco");
        treintaiseis = Resources.Load<AudioClip>("treintaiseis");
        treintaisiete = Resources.Load<AudioClip>("treintaisiete");
        treintaiocho = Resources.Load<AudioClip>("treintaiocho");
        treintainueve = Resources.Load<AudioClip>("treintainueve");
        isTreintaiseisPlayed = false;
        isTreintaisietePlayed = false;
        isTreintaiochoPlayed = false;
        isTreintainuevePlayed = false;
    }

    void Update()
    {
        src.volume = volumeLevel.volume;
        
        if (Score.youWin && !isWinSoundPlayed)
        {
            src.clip = felicidades;
            src.Play();
            isWinSoundPlayed = true;
        }
        if (Score.youLoose && !isLoseSoundPlayed)
        {
            src.clip = lastima;
            src.Play();
            isLoseSoundPlayed = true;
        }
        if (NarradorScript.firstText == true && !isFirstPlayed)
        {
            src.clip = first;
            src.Play();
            isFirstPlayed = true;
        }
        if (NarradorScript.secondText == true && !isSecondPlayed)
        {
            src.clip = second;
            src.Play();
            isSecondPlayed = true;
        }
        if (NarradorScript.thirdText == true && !isThirdPlayed)
        {
            src.clip = third;
            src.Play();
            isThirdPlayed = true;
        }
        if (NarradorScript.fourthText == true && !isFourthPlayed)
        {
            src.clip = fourth;
            src.Play();
            isFourthPlayed = true;
        }
        if (NarradorScript.fifthText == true && !isFifhtPlayed)
        {
            src.clip = fifth;
            src.Play();
            isFifhtPlayed = true;
        }
        if (NarradorScript.sixthText == true && !isSixthPlayed)
        {
            src.clip = sixth;
            src.Play();
            isSixthPlayed = true;
        }
        if (NarradorScript.seventhText == true && !isSeventhPlayed)
        {
            src.clip = seventh;
            src.Play();
            isSeventhPlayed = true;
        }
        if (NarradorScript.eighthText == true && !isEighthPlayed)
        {
            src.clip = eighth;
            src.Play();
            isEighthPlayed = true;
        }
        if (NarradorScript.eighth2Text == true && !isEighth2Played)
        {
            src.clip = eighth2;
            src.Play();
            isEighth2Played = true;
        }
        if (NarradorScript.ninethText == true && !isNinethPlayed)
        {
            src.clip = nineth;
            src.Play();
            isNinethPlayed = true;
        }
        if (NarradorScript.tenthText == true && !isTenthPlayed)
        {
            src.clip = tenth;
            src.Play();
            isTenthPlayed = true;
        }
        if (NarradorScript.eleventhText == true && !isEleventhPlayed)
        {
            src.clip = eleventh;
            src.Play();
            isEleventhPlayed = true;
        }
        if (NarradorScript.twelfthText == true && !isTwelfthPlayed)
        {
            src.clip = twelfth;
            src.Play();
            isTwelfthPlayed = true;
        }
        if (NarradorScript.thirteenthText == true && !isThirteenthPlayed)
        {
            src.clip = thirteenth;
            src.Play();
            isThirteenthPlayed = true;
        }
        if (NarradorScript.fourteenthText == true && !isFourteenthPlayed)
        {
            src.clip = fourteenth;
            src.Play();
            isFourteenthPlayed = true;
        }
        if (NarradorScript.fifteenthText == true && !isFifteenthPlayed)
        {
            src.clip = fifteenth;
            src.Play();
            isFifteenthPlayed = true;
        }
        if (NarradorScript.sixteenthText == true && !isSixteenthPlayed)
        {
            src.clip = sixteenth;
            src.Play();
            isSixteenthPlayed = true;
        }
        if (NarradorScript.seventeenthText == true && !isSeventeenthPlayed)
        {
            src.clip = seventeenth;
            src.Play();
            isSeventeenthPlayed = true;
        }
        if (NarradorScript.eighteenthText == true && !isEighteenthPlayed)
        {
            src.clip = eighteenth;
            src.Play();
            isEighteenthPlayed = true;
        }
        if (NarradorScript.nineteenthText == true && !isNineteenthPlayed)
        {
            src.clip = nineteenth;
            src.Play();
            isNineteenthPlayed = true;
        }
        if (NarradorScript.twentiethText == true && !isTwentiethPlayed)
        {
            src.clip = twentieth;
            src.Play();
            isTwentiethPlayed = true;
        }
        if (NarradorScript.twentyfirstText == true && !isTwentyfirstPlayed)
        {
            src.clip = twentyfirst;
            src.Play();
            isTwentyfirstPlayed = true;
        }
        if (NarradorScript.twentysecondText == true && !isTwentysecondPlayed)
        {
            src.clip = twentysecond;
            src.Play();
            isTwentysecondPlayed = true;
        }
        if (NarradorScript.twentythirdText == true && !isTwentythirdPlayed)
        {
            src.clip = twentythird;
            src.Play();
            isTwentythirdPlayed = true;
        }
        if (NarradorScript.twentyfourthText == true && !isTwentyfourthPlayed)
        {
            src.clip = twentyfourth;
            src.Play();
            isTwentyfourthPlayed = true;
        }
        if (NarradorScript.twentyfifthText == true && !isTwentyfifthPlayed)
        {
            src.clip = twentyfifth;
            src.Play();
            isTwentyfifthPlayed = true;
        }
        if (NarradorScript.twentysixthText == true && !isTwentysixthPlayed)
        {
            src.clip = twentysixth;
            src.Play();
            isTwentysixthPlayed = true;
        }
        if (NarradorScript.veintisieteText == true && !isVeintisietePlayed)
        {
            src.clip = veintisiete;
            src.Play();
            isVeintisietePlayed = true;
        }
        if (NarradorScript.veintiochoText == true && !isVeintiochoPlayed)
        {
            src.clip = veintiocho;
            src.Play();
            isVeintiochoPlayed = true;
        }
        if (NarradorScript.veintinueveText == true && !isVeintinuevePlayed)
        {
            src.clip = veintinueve;
            src.Play();
            isVeintinuevePlayed = true;
        }
        if (NarradorScript.treintaText == true && !isTreintaPlayed)
        {
            src.clip = treinta;
            src.Play();
            isTreintaPlayed = true;
        }
        if (NarradorScript.treintaiunoText == true && !isTreintaiunoPlayed)
        {
            src.clip = treintaiuno;
            src.Play();
            isTreintaiunoPlayed = true;
        }

        if (NarradorScript.treintaidosText == true && !isTreintaidosPlayed)
        {
            src.clip = treintaidos;
            src.Play();
            isTreintaidosPlayed = true;
        }
        if (NarradorScript.treintaitresText == true && !isTreintaitresPlayed)
        {
            src.clip = treintaitres;
            src.Play();
            isTreintaitresPlayed = true;
        }
        if (NarradorScript.treintaicuatroText == true && !isTreintaicuatroPlayed)
        {
            src.clip = treintaicuatro;
            src.Play();
            isTreintaicuatroPlayed = true;
        }
        if (NarradorScript.treintaicincoText == true && !isTreintaicincoPlayed)
        {
            src.clip = treintaicinco;
            src.Play();
            isTreintaicincoPlayed = true;
        }
        if (NarradorScript.treintaiseisText == true && !isTreintaiseisPlayed)
        {
            src.clip = treintaiseis;
            src.Play();
            isTreintaiseisPlayed = true;
        }
        if (NarradorScript.treintaisieteText == true && !isTreintaisietePlayed)
        {
            src.clip = treintaisiete;
            src.Play();
            isTreintaisietePlayed = true;
        }
        if (NarradorScript.treintaiochoText == true && !isTreintaiochoPlayed)
        {
            src.clip = treintaiocho;
            src.Play();
            isTreintaiochoPlayed = true;
        }
        if (NarradorScript.treintainueveText == true && !isTreintainuevePlayed)
        {
            src.clip = treintainueve;
            src.Play();
            isTreintainuevePlayed = true;
        }

        if (Time.timeScale == 0f)
        {
            src.Pause();
        }
        else
        {
            src.UnPause();
        }
    }
}