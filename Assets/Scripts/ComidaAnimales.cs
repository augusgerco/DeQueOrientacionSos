using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaAnimales : MonoBehaviour
{
    public string categoriaAnimal;
    public int diasAnimal;

    string codigoGato = "G";
    string codigoPerroPeque = "PP";
    string codigoPerroGrande = "PG";

    int gramosGato = 300;
    int gramosPerroPeque = 400;
    int gramosPerroGrande = 700;

    int cantidadTotalAlimento = 0;
    int precioAlimento = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (categoriaAnimal != codigoGato && categoriaAnimal != codigoPerroGrande && categoriaAnimal != codigoPerroPeque) {
            Debug.Log("Error");
            return;
        }
        if (diasAnimal <= 3) {
            Debug.Log("Error");
            return;
        }

        if (categoriaAnimal == codigoGato){
            cantidadTotalAlimento = cantidadTotalAlimento + gramosGato * diasAnimal;
        } 
        if (categoriaAnimal == codigoPerroGrande){
            cantidadTotalAlimento = cantidadTotalAlimento + gramosPerroGrande * diasAnimal;
        }
        if (categoriaAnimal == codigoPerroPeque){
            cantidadTotalAlimento = cantidadTotalAlimento + gramosPerroPeque * diasAnimal;
        }

        Debug.Log("Para ese período se necesitan " + cantidadTotalAlimento + " gramos de alimento");
        
        precioAlimento = precioAlimento + cantidadTotalAlimento * 80;
        Debug.Log("El costo de la cantidad de alimento calculado es de $" + precioAlimento);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
