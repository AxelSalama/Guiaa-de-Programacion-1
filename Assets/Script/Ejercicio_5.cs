using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Realizá un programa que, dados dos números enteros num1 y num2 cargados desde  el Inspector 
//muestre el resultado de la división del primero por el segundo en la consola siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.  
//En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:  “No se puede dividir por cero”. 

public class Ejercicio_5 : MonoBehaviour
{
    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        int res;

        if (n2 == 0)
        {
            Debug.Log("Error, no se puede dividir por cero");
        }
        else
        {
            res = n1 / n2;

            Debug.Log(n1 + "/" + n2 + "=" + res);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
