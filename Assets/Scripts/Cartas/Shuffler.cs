using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shuffler : MonoBehaviour
{

    [SerializeField]
    private CartaScriptableObject[] barajaCompleta;

    [SerializeField]
    private CartaLoader[] cartasEnJuego;

    private CartasState estado;

    // Start is called before the first frame update
    void Awake()
    {
        if(cartasEnJuego.Length > barajaCompleta.Length)
            throw new System.Exception("NO PUEDE HABER MÁS CARTAS EN JUEGO QUE CARTAS EN BARAJA");
        
    }

    void Start() {

        estado = GuardadoCartas.Instance.cartas;
        AleatorizarCartas();
    }

    public void AleatorizarCartas() {

        print("NUEVAS CARTAS!");

        // arreglo de números del mismo tamano que la baraja
        int[] repeticiones = new int[barajaCompleta.Length];

/*
        // esto no es indispensable, lo pongo para que veamos que de entrada todos están en 0
        for(int i = 0; i < repeticiones.Length; i++){
            print(repeticiones[i]);
        }
*/
        // si hubiera muchísimas cartas evaluar usar un Dictionary

        // tipo de iteración que va recorriendo cada elemento de una colección
        // al que le pone un nombre temporal
        // (es una referencia que apunta a diferentes espacios en memoria)
        for(int i = 0; i < cartasEnJuego.Length; i++){

            // ciclo para evitar repeticiones 
            int random = 0;

            do{
                
                // cuando se genera un random se una semilla
                UnityEngine.Random.InitState((int)DateTime.Now.Ticks);

                // obtener valor aleatorio entre mínimo y máximo de la baraja
                random = UnityEngine.Random.Range(0, barajaCompleta.Length);
            
            } while(repeticiones[random] == 1);

            // marcar carta como utilizada
            repeticiones[random] = 1;
            // cartaActual.data = barajaCompleta[random];

            estado.idsDeCartas[i] = random;
            
        }

        RecargarCartas();
    }

    public void RecargarCartas() {

        // actualizar cartas visibles basándose en el estado
        // 2 lugares donde se altera el estado 
        // 1. al aleatorizar nuevas cartas
        // 2. al cargar cartas de archivo
        for(int i = 0; i < cartasEnJuego.Length; i++){
            print(barajaCompleta[GuardadoCartas.Instance.cartas.idsDeCartas[i]]);
            cartasEnJuego[i].ActualizarCarta(barajaCompleta[GuardadoCartas.Instance.cartas.idsDeCartas[i]]);
        }
    }

    public void CargarDesdeArchivo() {

        print("CARGANDO DESDE ARCHIVO");
        GuardadoCartas.Instance.Load();
        // el objeto cambio y hay que volver a asignar
        estado = GuardadoCartas.Instance.cartas;
        RecargarCartas();
    }

    public void GuardarAArchivo() {
        print("GUARDANDO EN ARCHIVO");
        GuardadoCartas.Instance.Save();
    }

}
