using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenProgramación : MonoBehaviour
{
    public string nombreDelUsuario;
    public int añoDelUsuario;
    public string orientacionDelUsuario;
    // Start is called before the first frame update
    void Start()
    {
        
        if (nombreDelUsuario == "")
        {

            Debug.Log("Nombre del usuario incorrecto");
            return;
        }

        if (añoDelUsuario > 5 || añoDelUsuario < 1)
        {
            Debug.Log("Año del usuario incorrecto");
            return;
        } else if (añoDelUsuario < 3) 
        Debug.Log("Error. Aún estás en el ciclo básico");

        if (orientacionDelUsuario != "T" & orientacionDelUsuario != "H" & orientacionDelUsuario != "M" & orientacionDelUsuario != "G" & orientacionDelUsuario != "D")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
        Debug.Log(" Muchas gracias " + nombreDelUsuario + "!");

    }

    // Update is called once per frame
    void Update()
    {
    }
}
