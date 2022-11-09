using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GuardadoCartas : MonoBehaviour
{

    public static GuardadoCartas Instance {
        get;
        private set;
    }

    public CartasState cartas;
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
            ruta = Application.persistentDataPath + "/guardadoDatos.data";
        print(ruta);

        Load();
    }

    public void Save(){
        
        print("GUARDANDO DATOS EN ARCHIVO");

        // abrimos archivo
        FileStream datosStream = new FileStream(ruta, FileMode.Create);
        
        // creamos el serializador / deserializador
        BinaryFormatter convertidor = new BinaryFormatter();
        
        // serializamos objeto en archivo
        convertidor.Serialize(datosStream, cartas);

        // cerramos archivo
        datosStream.Close();
    }

    public void Load(){

        print("CARGANDO DATOS DE ARCHIVO");
        
        // comprobamos que exista
        if(File.Exists(ruta)){
            
            // abrir archivo
            FileStream datosStream = new FileStream(ruta, FileMode.Open);

            // creamos objeto serializador / deserializador
            BinaryFormatter convertidor = new BinaryFormatter();

            // deserializamos
            // el "as" es casting - cambio de tipo en tiempo de ejecución
            CartasState datosTemp = convertidor.Deserialize(datosStream) as CartasState;

            // cerramos
            datosStream.Close();

            print("*** DESDE ARCHIVO *** ");
            // regresamos resultado
            cartas = datosTemp;
        } else {

             print("*** NO EXISTÍA *** ");
            // si no hay un archivo que deserializar 
            // podemos regresar un objeto nuevo
            CartasState estadoTemp = new CartasState();
            estadoTemp.idsDeCartas = new int[3]; 
            cartas = estadoTemp;
        }
        
    }
}
