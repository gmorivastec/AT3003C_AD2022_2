using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbadorArchivo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        // guardar
        if(Input.GetKeyDown(KeyCode.S)){

            GuardadoArchivo.Instance.Save();
        }

        // modificar datos
        if(Input.GetKeyDown(KeyCode.D)){

            GuardadoArchivo.Instance.datos.nombre = "PERSONAJE CHIDO";
            GuardadoArchivo.Instance.datos.experiencia++;
            GuardadoArchivo.Instance.datos.vida--;
        }
    }
}
