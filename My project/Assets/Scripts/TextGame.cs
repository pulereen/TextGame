using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witam w grze - pomyœl o liczbie od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna, wieksza czy mniejsza od 500?");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("Nacisnieto gorna strzalke");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Nacisnieto dolna strzalke");
        }

    }
}
