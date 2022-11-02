using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// IDEAL - SEPARACIÓN DE RESPONSABILIDADES 
// qué es eso?
// 1 código se dedica a 1 actividad
public class GuardadoPlayerPrefs : MonoBehaviour
{

    // PARA GUARDAR UTILIZANDO PLAYER PREFS NECESITAMOS LLAVES 
    // UNA LLAVE ES UN STRING QUE SIRVE PARA RECONOCER UN VALOR
    // DENTRO DE LAS PLAYER PREFS

    // vamos a usar valores readonly
    private readonly string NOMBRE = "nombre";
    private readonly string EDAD = "edad";
    private readonly string PESO  = "peso";

    // POR QUÉ USAR CONSTANTES?
    // 1 - EVITAR DEDAZOS- cuando escribimos strings podemos escribirlo mal
    // y el código sigue "funcionando"

    // 2 opciones para guardado local de datos
    
    // 1 - playerprefs 
    // se guardan en algún lugar del sistema como registros llave - valor
    // https://docs.unity3d.com/ScriptReference/PlayerPrefs.html

    // utiliza una llave para guardar algo de contenido
    // sólo puede guardar primitivos (tipos básicos, NO clases)
    // int, float, string 

    // Start is called before the first frame update
    
    public static GuardadoPlayerPrefs Instance {
        get;
        private set;
    }

    public string nombre;
    public int edad;
    public float peso;

    void Awake() {

        // checar que sea sólo 1 instancia
        if(Instance != null){
            Destroy(gameObject);
            return;
        } 

        // si llegamos aquí era nulo
        Instance = this;
    }

    public void Guardar() {

        PlayerPrefs.SetString(NOMBRE, nombre);
        PlayerPrefs.SetInt(EDAD, edad);
        PlayerPrefs.SetFloat(PESO, peso);

        // puede ser explícito y si no se llama en 
        // OnApplicationQuit
        // PlayerPrefs.Save();
    }

    public void Leer() {

        if(PlayerPrefs.HasKey(NOMBRE))
            nombre = PlayerPrefs.GetString(NOMBRE);
        
        if(PlayerPrefs.HasKey(EDAD))
            edad = PlayerPrefs.GetInt(EDAD);
        
        if(PlayerPrefs.HasKey(PESO))
            peso = PlayerPrefs.GetFloat(PESO);
    }
}
