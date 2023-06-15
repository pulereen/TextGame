using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int shoot = 500 / 2;

    // Start is called before the first frame update
    void Start()
    {
       

        Debug.Log("Witam w grze - pomyœl o liczbie od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna, wieksza czy mniejsza od 500?");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna, wieksza czy mniejsza od " + shoot + "?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna, wieksza czy mniejsza od " + shoot + "?");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("KOMPUTER ZGADL LICZBE");
        }

    }
}
