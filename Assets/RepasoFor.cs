using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int enteroUno;
    public int enteroDos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i > 5; i++)
        {
            Debug.Log(i);
        }

//enteros multiplos de entre 3 y 6 y 30 inclusive 
        for(int i = 6; i < 31; i +=3)
        {
            Debug.Log(i);
        }

        //enteros desde 0 hasta 50 excepto multiplos de 7

        for(int i = 0; i<=50; i++)
        {
            if (i % 7 != 0)
            {
                Debug.Log(i);
            }
        }

        //escribir los enteros entre dos enteros ingresados por inspectot (no inclusive)

        for(int i = enteroUno + 1 ; i<enteroDos; i++)
        {
            Debug.Log(i);
        }

        //escribir los enteros entre 100 y 0(inclusive) de manera descendente
        
        for(int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
