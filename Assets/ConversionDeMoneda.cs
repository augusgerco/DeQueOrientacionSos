using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public string monedaAConvertir;
    public int montoAConvertir;

    string monedaDolares = "D";
    string monedaReales = "R";
    string monedaEuros = "E";

    float cotizacionDolar = 1163.68f;
    float cotizacionReal = 204.47f;
    float cotizacionEuro = 1327.71f;

    float valorConvertido = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (monedaAConvertir != monedaDolares && monedaAConvertir != monedaReales && monedaAConvertir != monedaEuros){
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        if (montoAConvertir < 1000){
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (monedaAConvertir == monedaDolares){
            valorConvertido = valorConvertido + montoAConvertir / cotizacionDolar;
        } else if (monedaAConvertir == monedaReales){
            valorConvertido = valorConvertido + montoAConvertir / cotizacionReal;
        } else {
            valorConvertido = valorConvertido + montoAConvertir / cotizacionEuro;
        }
        
        Debug.Log("El monto convertido es de $" + valorConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
