using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int anioAlumno = 0;
    public string orientacionAlumno;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == " "){
            Debug.Log("Error");
            return;
        }
        if (anioAlumno < 1 && anioAlumno > 5){
            Debug.Log("Error");
            return;
        }
        if (anioAlumno < 3 || anioAlumno > 5){
            Debug.Log("Error. Aun estas en ciclo basico");
            return;
        }
        if (orientacionAlumno == "T" || orientacionAlumno == "D" || orientacionAlumno == "G" || orientacionAlumno == "M" || orientacionAlumno == "H"){
            Debug.Log("Muchas gracias " + nombreAlumno + "!");
        } else {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
