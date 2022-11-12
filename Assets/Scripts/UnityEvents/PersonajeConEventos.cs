using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Evento2: UnityEvent<float>{}
[System.Serializable]
public class Evento3: UnityEvent<string, int>{}
public class PersonajeConEventos : MonoBehaviour
{
    // como acceder a datos de un objeto 
    // 1. polling / sondeo - preguntar directamente a objeto
    // 2. por medio de un sistema de suscripción a eventos

    // acoplamiento 

    // hacer evento hace que avisemos al exterior que algo pasó
    [SerializeField]
    private UnityEvent _vidaCero;
    
    [SerializeField]
    private Evento2 _evento2;
    
    [SerializeField]
    private Evento3 _evento3;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            // aquí detonamos explícitamente con teclazo
            // pero en juego va a ser resultado de una acción que suceda

            // invoke - avisarle a todos los suscriptores que "evento" pasó
            _vidaCero.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            _evento2.Invoke(3.1416f);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            _evento3.Invoke("HOLA AMIGUITOS", 15);
        }
    }
}
