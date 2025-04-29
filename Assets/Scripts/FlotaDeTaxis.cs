using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadDeTaxis;
    public int cantidadDiasTrabajados;

    int litrosPorDia = 6;
    int precioLitroCombustible = 130;

    float precioTotalCombustible = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(cantidadDiasTrabajados < 5){
            Debug.LogError("Error. Hay un minimo de 5 dias de trabajo");
            return;
        }
        if(cantidadDeTaxis < 1){
            Debug.LogError("Error. Hay un minimo de 1 taxi por flota");
            return;
        }

        precioTotalCombustible = precioTotalCombustible + litrosPorDia * cantidadDeTaxis * cantidadDiasTrabajados * precioLitroCombustible;

    // supera los 100 litros
        if(cantidadDiasTrabajados * cantidadDeTaxis * litrosPorDia > 100){
            precioTotalCombustible = precioTotalCombustible * 0.80f;
        }

        Debug.Log("Una flota de " + cantidadDeTaxis + " unidades trabajando durante "  + cantidadDiasTrabajados + " días implicará un gasto de " + precioTotalCombustible + " pesos en concepto de combustible");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
