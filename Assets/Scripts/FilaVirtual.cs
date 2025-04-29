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

    float valorTotalCompra = 0;

    // Start is called before the first frame update
    void Start()
    {
        //que entrada elegiste
        if(tipoDeEntrada != entradaBasica && tipoDeEntrada != entradaNormal && tipoDeEntrada != entradaPremium){
            Debug.Log("El codigo de entrada es incorrecto");
            return;
        }
        // Vemos cuántas entradas quiere y validamos
        if (tipoDeEntrada == entradaBasica) {
            cantidadBasica = cantidadDeEntradas;

            if (cantidadBasica > 4 || cantidadBasica <= 0) {
                Debug.Log("Error. El máximo de entradas básicas adquiribles es de 4 y el mínimo de compra es una");
                return;
            } else {
                valorTotalCompra = cantidadBasica * precioBasica;
            }
        }

        if (tipoDeEntrada == entradaNormal) {
            cantidadNormal = cantidadDeEntradas;

            if (cantidadNormal > 6 || cantidadNormal <= 0) {
                Debug.Log("Error. El máximo de entradas normales adquiribles es de 6 y el mínimo de compra es una");
                return;
            } else {
                valorTotalCompra = cantidadNormal * precioNormal;
            }
        }

        if (tipoDeEntrada == entradaPremium) {
            cantidadPremium = cantidadDeEntradas;

            if (cantidadPremium <= 0) {
                Debug.Log("Error. Debes adquirir al menos una entrada premium");
                return;
            } else {
                valorTotalCompra = cantidadPremium * precioPremium;
            }
        }

        // Checkeamos si el usuario usó prioridad correctamente
        if (tipoDeEntrada != entradaPremium && prioridadEnFila == true) {
            Debug.Log("Error. La prioridad en fila es solo para entradas premium");
            return;
        } else if (tipoDeEntrada == entradaPremium && prioridadEnFila == true) {
            // Solo sumamos el 15% extra sobre el valor de las entradas premium
            valorTotalCompra += cantidadPremium * precioPremium * 0.15f;
        }
        Debug.Log("El tipo de entrada elegido es: " + tipoDeEntrada + ", la cantidad es de " + cantidadDeEntradas + " entradas, y el total de la compra es de $" + valorTotalCompra);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
