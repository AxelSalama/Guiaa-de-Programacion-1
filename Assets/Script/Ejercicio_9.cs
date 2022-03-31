using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Realizá un programa que resuelva el siguiente problema:  
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. */

public class Ejercicio_9 : MonoBehaviour
{
    public string nomb1;
    public string nomb2;
    public string nomb3;

    public int capital1;
    public int capital2;
    public int capital3;

    // Start is called before the first frame update
    void Start()
    {
        int captotal = capital1 + capital2 + capital3;
        int porcent1 = capital1 * 100 / captotal;
        int porcent2 = capital2 * 100 / captotal;
        int porcent3 = capital3 * 100 / captotal;

        Debug.Log("Se aportaron " + captotal + "pesos en total");
        Debug.Log("La persona 1 aporto el capital" + capital1 + "pesos. Aporto un " + porcent1 + " % del capital");
        Debug.Log("La persona 2 aporto el capital" + capital2 + "pesos. Aporto un " + porcent2 + " % del capital");
        Debug.Log("La persona 3 aporto el capital" + capital3 + "pesos. Aporto un " + porcent3 + " % del capital");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
