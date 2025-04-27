using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string gustoPedido;
    public int gramosPedido;

    string gustoFrutilla = "FRU";
    string gustoChocolate = "CHO";
    string gustoDulceDeLeche = "DDL";

    float costoPedido = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (gustoPedido != gustoFrutilla && gustoPedido != gustoChocolate && gustoPedido != gustoDulceDeLeche){
            Debug.Log("Error. Elegir un codigo de gusto valido");
            return;
        } 
        if (gramosPedido < 250 || gramosPedido > 3000){
            Debug.Log("Error. Elegir gramos de helado validos");
            return;
        }

        costoPedido = costoPedido + gramosPedido * 0.5f;
    
        if (gustoPedido == gustoFrutilla){
            costoPedido = costoPedido * 0.9f;
        }

        Debug.Log("El costo del pedido es de $" + costoPedido);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
