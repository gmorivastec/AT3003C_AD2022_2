using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbadorPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){

            // guardar datos
            print("GUARDANDO DATOS EN PLAYER PREFS");
            GuardadoPlayerPrefs.Instance.nombre = "El Killer";
            GuardadoPlayerPrefs.Instance.peso = 2;
            GuardadoPlayerPrefs.Instance.Guardar();
        }

        if(Input.GetKeyDown(KeyCode.W)){

            // leer datos
            print("LEYENDO DATOS EN PLAYER PREFS");
            GuardadoPlayerPrefs.Instance.Leer();
            print(GuardadoPlayerPrefs.Instance.nombre);
            print(GuardadoPlayerPrefs.Instance.edad);
            print(GuardadoPlayerPrefs.Instance.peso);
        }

        if(Input.GetKeyDown(KeyCode.E)){

            // incrementar edad
            GuardadoPlayerPrefs.Instance.edad++;
            print("EDAD INCREMENTADA: " + GuardadoPlayerPrefs.Instance.edad);
        }
    }
}
