using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasse : MonoBehaviour
{

    [Header("Uppgift2")]
    public float userValue;
    [Header("Uppgift 2")]
    public int Uppgift2poäng = 10;
    public int tärningplus;
    public int tärningminus;
    public bool fårkasta = true;
    [Header("Uppgift 3")]
    public int drakeHP;
    public int drakedmg;
    public int playerHP = 100;
    public int playerdmg;
    public int chance;

    // Use this for insitialization
    void Start()
    {
        // Uppgift2s();
        Uppgift3a();
    }
    void Uppgift3a()
    {
        drakeHP = Random.Range(100, (150 + 1));
    }

    // Update is called once per frame
    void Update()
    {
        //Uppgift1();
        // Uppgift2();
        Uppgift3b();
    }
    void Uppgift3b()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerdmg = Random.Range(5, (25 + 1));
            chance = Random.Range(0, (1 + 1));
            if (chance == 1)
            {

                drakedmg = Random.Range(10, (20 + 1));
            }
            Debug.Log(string.Format("Player HP = {0}", (playerHP - drakedmg)));

            Debug.Log(string.Format("Drake HP = {0}", (drakeHP - playerdmg)));
        }

        if (drakeHP <= 0)
        {
            Debug.Log("Drake Död");
        }

        if (playerHP <= 0)
        {
            Debug.Log("Player död");
        }
    }
    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
    }
    void Uppgift2()
    {
        if ((Input.GetKeyDown(KeyCode.R)) && (fårkasta == true))
        {
            tärningplus = Random.Range(1, (6 + 1));
            tärningminus = Random.Range(1, (6 + 1));
            Uppgift2poäng = Uppgift2poäng += tärningplus - tärningminus;
            Debug.Log(Uppgift2poäng);
        }
        if (Uppgift2poäng >= 20)
        {
            Debug.Log("Du Vann");
            fårkasta = false;
        }
        if (Uppgift2poäng <= 0)
        {
            Debug.Log("Du förlorade");
            fårkasta = false;
        }
    }
    void Uppgift2s()
    {
        Debug.Log(string.Format("Du har {0} poäng", Uppgift2poäng));
    }
}

