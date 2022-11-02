using UnityEngine;
using System;

// VAMOS A HACER UNA CLASE QUE VA A SER SERIALIZADA
// SERIALIZAR?

// sabemos que tiene que ver con modificar un dato para hacerlo visible en editor
// (dato debe ser serializable)

// SERIALIZAR ES UN PROCESO QUE TRANSFORMA UN OBJETO 
// EN UNA REPRESENTACIÓN QUE SE PUEDE GUARDAR / TRANSMITIR

// puede ser XML, JSON, binario

// OJO: NO ESTÁ CIFRADO

[Serializable]
public class Datos
{
    public int vida;
    public int experiencia;
    public string nombre;
    public float[] posicion;
}
