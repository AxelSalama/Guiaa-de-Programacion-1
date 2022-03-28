using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5, 
 respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
a. Suma 
b. Producto 
*/
public class Ejercicio_2 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int res;
    // Start is called before the first frame update
    void Start()
    {
        num1 += num2;
        Debug.Log(res);

        num1 *= num2;
        Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
