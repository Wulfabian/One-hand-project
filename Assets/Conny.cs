using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conny : MonoBehaviour
{

    //Int = heltal (Variabler) 
    //float = decimaler (Variabler)
    public float uppgift3tal = 0;
    public float uppgift4bas = 0;
    [Range(0, 360)] public float uppgift5angle;
    public float uppgift5pieces;
    public float uppgift7radius;
    public float uppgift8damage;
    public float uppgift8aDemonHP;
    public float uppgift8bDeomner;
    public float uppgift8cmaxdamage;
    public float uppgift8cminimumdamage;
    private float uppgift9count = 2;
    // float uppgift10countMulti = 2;
    //double = en dubbel float (Variabler)
    //bool = Yes or no
    //char = ett tecken (Kan vara tecknet "5" men inte värdet "5" 
    //string = char fast hur många tecken som helst
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public string uppgift6username;

    // Use this for initialization
    void Start()
    {
        TestFunktion();
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgfit7();
        Uppgift8();
       // Uppgift10();
    }

    void TestFunktion()
    {
        Debug.Log("Detta är min TestFunktion()");
    }


    // Update is called once per frame
    void Update()
    {
        //Uppgift9();
    }

    void Uppgift1()
    {

        Debug.Log(
            string.Format(
                "Svaret på (963f * 421f) - (175463f / 87f) är {0}"
                , (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {

        Debug.Log(
            string.Format(sentence1)
            );
        Debug.Log(
            string.Format(sentence2)
            );
        Debug.Log(
            string.Format(sentence3)
            );
    }

    void Uppgift3()
    {
        //Debug.Log(Mathf.Pow(Uppgift3tal, 2));
        //Debug.Log(Mathf.Sqrt(Uppgift3tal));

        Debug.Log(string.Format(
            "Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}",
            uppgift3tal, Mathf.Pow(uppgift3tal, 2), Mathf.Sqrt(uppgift3tal)));
    }

    void Uppgift4()
    {
        Debug.Log(string.Format(
            "En triangel med höjden 8m och basen {0}m har arean {1}m^2",
            uppgift4bas, (uppgift4bas * 8 / 2)));
    }

    void Uppgift5()
    {
        Debug.Log(string.Format(
            "Om man delar denna cirkel i bitar med vinkeln {0} så kan man få {1} hela bitar",
            uppgift5angle, (360 / uppgift5angle)));

        //a
        Debug.Log(string.Format("Om man vill ha {0} bitar så kommer bitarna ha vinkeln {1}",
            uppgift5pieces, (360 / uppgift5pieces)));

    }

    void Uppgift6()
    {
        Debug.Log(string.Format("Boss {0} of doom", uppgift6username));
    }

    void Uppgfit7()
    {
        Debug.Log(string.Format("Om ett klot har radien {0}m så kommer 2978 sådana klot ha volymen {1}m^3",
            uppgift7radius, ((4 * 3.14 * Mathf.Pow(uppgift7radius, 2f) / 3) * 2978)));
    }

    void Uppgift8()
    {
        Debug.Log(string.Format("Om dina attacker skadar {0} så krävs det {1} attacker för att döda en demon med 890000 HP"
            , uppgift8damage, 890000 / uppgift8damage));

        //a
        Debug.Log(string.Format("Om dina attacker skadar {0} så krävs det {1} attacker för att döda en demon med {2} HP"
            , uppgift8damage, uppgift8aDemonHP / uppgift8damage, uppgift8aDemonHP));

        //b
        Debug.Log(string.Format("Om dina attacker skadar {0} så krävs det {1} attacker för att döda {2} demoner med {3} HP"
            , uppgift8damage, ((uppgift8aDemonHP / uppgift8damage) * uppgift8bDeomner), uppgift8bDeomner, uppgift8aDemonHP));

        //c
        Debug.Log(string.Format("Om dina attacers max skada är {0} och minium skada är {1} så kommer det max krävas {2} attacker för o döda {3} demoner med" +
            "{4} HP eller minst {5} antal attacker."
            , uppgift8cmaxdamage, uppgift8cminimumdamage, ((uppgift8aDemonHP / uppgift8cminimumdamage) * uppgift8bDeomner), uppgift8bDeomner, uppgift8aDemonHP
            , ((uppgift8aDemonHP / uppgift8cmaxdamage) * uppgift8bDeomner)));

        Debug.Log(string.Format(" Då skulle det i snitt ta {0} antal attacker för att döda dem"
            , ((uppgift8aDemonHP / uppgift8cminimumdamage) * uppgift8bDeomner) +
            ((uppgift8aDemonHP / uppgift8cmaxdamage) * uppgift8bDeomner) / 2));
    }

    void Uppgift9()
    {
        Debug.Log(string.Format("{0}"
            , uppgift9count *= 2));
    }

   // void Uppgift10()
   // {
       // Debug.Log(string.Format("2 * 3 = {0} .... {0}/ 2 = {1}"
          //  , (uppgift10countMulti * 3), (uppgift10countMulti * 3), ));
   // }

}
