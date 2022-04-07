using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

public class ej2 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    public int monto;
    int sobrante;
    int faltante;
    int sumaPrecios;
    // Start is called before the first frame update
    void Start()
    {
        sumaPrecios = precio1 + precio2 + precio3;
        sobrante = monto-sumaPrecios;
        faltante = sumaPrecios - monto;
        
        if (precio1 + precio2 + precio3 < monto)
        {
            Debug.Log("el monto es mayor a la suma de los 3 precios");
            Debug.Log("te sobran" + sobrante + "pesos");
        }
        else if (precio1 + precio2 + precio3 > monto)
        { 
            Debug.Log("el monto es menor a la suma de los 3 precios");
            Debug.Log("te faltan"+faltante+"pesos");
        }
        else
        {
            Debug.Log("el monto y la suma de los 3 precios son iguales");
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
