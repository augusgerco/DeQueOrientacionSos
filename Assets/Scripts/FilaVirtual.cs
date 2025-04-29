using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaVirtual : MonoBehaviour
{
    public string tipoDeEntrada;
    public int cantidadDeEntradas;
    public bool prioridadEnFila;

    string entradaBasica = "b";
    string entradaNormal = "n";
    string entradaPremium = "p";

    int cantidadBasica = 0;
    int cantidadNormal = 0;
    int cantidadPremium = 0;

    int precioBasica = 800;
    int precioNormal = 1200;
    int precioPremium = 2000;

    // Start is called before the first frame update
    void Start()
    {
        //que entrada elegiste
        if(tipoDeEntrada != entradaBasica || tipoDeEntrada != entradaNormal || tipoDeEntrada != entradaPremium){
            Debug.Log("El codigo de entrada es incorrecto");
            return;
        }
        //vemos cuantas entradas quiere
        if(tipoDeEntrada == entradaBasica){
            cantidadBasica = cantidadBasica + cantidadDeEntradas;
        }
        //vemos cuantas entradas quiere
        if(tipoDeEntrada == entradaNormal){
            cantidadNormal = cantidadNormal + cantidadDeEntradas;
        }
        //vemos cuantas entradas quiere
        if(tipoDeEntrada == entradaPremium){
            cantidadPremium = cantidadPremium + cantidadDeEntradas;
        }

        //vemos si la cantidad de entradas es valida
        if(cantidadBasica >= 4 && cantidadBasica < 0){
            Debug.Log("Error. El maximo de entradas normales adquiribles es de 6 y el minimo de compra es una");
            return;
        }
        if(cantidadNormal >= 6 && cantidadNormal < 0){
            Debug.Log("Error. El maximo de entradas normales adquiribles es de 6 y el minimo de compra es una");
            return;
        }
        if(cantidadPremium < 0){
            Debug.Log("Error. Debes adquirir al menos una entrada");
            return;
        }
        //checkeamos si el usuario uso premium o no
        if(tipoDeEntrada != entradaPremium && prioridadEnFila = true){
            Debug.Log("Error. La prioridad en fila es solo para entradas premium");
            return;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
