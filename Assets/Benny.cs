using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benny : MonoBehaviour
{

    public bool IsChecked;
    public int MyIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Nej");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= större än eller lika med
        // > större än
        // < mindre än
        // && OCH (and)
        // || ELLER (or)

        //if (MyIntValue == 10 || IsChecked == true)
        //{
        //    print("Måndag");
        //}
        //else if (MyIntValue == 9)
        //{
        //    print("Tisdag");
        //}
        //else
        //{
        //    print("Okänd dag");
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Reload");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //0,1 2 3 4 5 6 7 8 9
            MyIntValue = Random.Range(0, 10);
            // 0,012 0,4212 0,512, 6,412
            print(Random.Range(0, 10f));
            print("Lean left");
        }
    }
}
