using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int campoVendidas = 0;
    public int plateasVendidas = 0;

    int predioEvento = 36600;
    int campoTotalidad = 20400;
    int plateasTotalidad = 16200;

    int precioCampo = 1200;
    int precioPlateas = 2000;

    int recaudacionCampo = 0;
    int recaudacionPlateas = 0;
    int recaudacionTotal = 0;

    // Start is called before the first frame update
    void Start()
    {
        int totalidadVendidas = campoVendidas + plateasVendidas;

        if (campoVendidas < 0 || campoVendidas > campoTotalidad){
            Debug.Log("Error. No se pudieron haber vendido mas entradas de la totalidad del campo");
            return;
        }
        if (plateasVendidas < 0 || plateasVendidas > plateasTotalidad){
            Debug.Log("Error. No se pudieron haber vendido mas entradas de la totalidad de las plateas");
            return;
        }
        if (totalidadVendidas < predioEvento){
            Debug.Log("La cantidad del total de la capacidad del predio que quedó vacante es de " + (predioEvento - totalidadVendidas));
        } else {
            Debug.Log("Sold out!");
        }
        if (totalidadVendidas > (predioEvento / 2)){
            Debug.Log("El festival fue un éxito!");
        } else {
            Debug.Log("Debemos mejorar la convocatoria");
        }

        recaudacionCampo = recaudacionCampo + campoVendidas * precioCampo;
        recaudacionPlateas = recaudacionPlateas + plateasVendidas * precioPlateas;

        recaudacionTotal = recaudacionTotal + recaudacionCampo + recaudacionPlateas;
        Debug.Log("La recaudacion del campo fue de $" + recaudacionCampo);
        Debug.Log("La recaudacion de las plateas fue de $" + recaudacionPlateas);
        Debug.Log("La recaudacion del total del evento fue de $" + recaudacionTotal);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
