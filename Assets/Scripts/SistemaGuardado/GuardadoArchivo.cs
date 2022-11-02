using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GuardadoArchivo : MonoBehaviour
{

    public static GuardadoArchivo Instance {
        get;
        private set;
    }

    public Datos datos;
    public string ruta;

    void Awake() {

        // checar que sea sólo 1 instancia
        if(Instance != null){
            Destroy(gameObject);
            return;
        } 

        // si llegamos aquí era nulo
        Instance = this;
        if(ruta == "")
            ruta = Application.persistentDataPath + "/guardado.data";
        print(ruta);

        datos = Load();
    }

    public void Save(){
        
        print("GUARDANDO DATOS EN ARCHIVO");

        // abrimos archivo
        FileStream datosStream = new FileStream(ruta, FileMode.Create);
        
        // creamos el serializador / deserializador
        BinaryFormatter convertidor = new BinaryFormatter();
        
        // serializamos objeto en archivo
        convertidor.Serialize(datosStream, datos);

        // cerramos archivo
        datosStream.Close();
    }

    public Datos Load(){

        print("CARGANDO DATOS DE ARCHIVO");
        
        // comprobamos que exista
        if(File.Exists(ruta)){
            
            // abrir archivo
            FileStream datosStream = new FileStream(ruta, FileMode.Open);

            // creamos objeto serializador / deserializador
            BinaryFormatter convertidor = new BinaryFormatter();

            // deserializamos
            // el "as" es casting - cambio de tipo en tiempo de ejecución
            Datos datosTemp = convertidor.Deserialize(datosStream) as Datos;

            // cerramos
            datosStream.Close();

            // regresamos resultado
            return datosTemp;
        } else {

            // si no hay un archivo que deserializar 
            // podemos regresar un objeto nuevo
            return new Datos();
        }
        
    }
}
