using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Pruebitas1
{

    Matematicas[] arregloMatematicas;

    // constructor 
    // método que se ejecuta al crear un objeto de una clase
    // corre una vez al inicio
    public Pruebitas1() {
        arregloMatematicas = GameObject.FindObjectsOfType<Matematicas>();    
    }
    
    [Test]
    public void VerificarNulidad()
    {
        // mas similar a casos reales

        foreach(Matematicas actual in arregloMatematicas){

            Debug.Log(actual.gameObject.transform.name);

            Assert.IsNotNull(actual.Shuffler1);
            Assert.IsNotNull(actual.Shuffler2);
            Assert.IsNotNull(actual.Shuffler3);
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void SumaTest()
    {
        // lo que hacemos en un test case
        // es probar lógica específica de alguna parte del sistema 

        // declarar objetos, invocar métodos, variables, etc
        // se usa la clase assert para hacer la comparación
        // generalmente hay relacion 1v1 entre un caso de prueba y un método
    
        //Assert.AreEqual(2, m.Sumar(1, 1));
        foreach(Matematicas actual in arregloMatematicas){

            Debug.Log(actual.gameObject.transform.name);

            // incluye TODAS las opciones que se te ocurran!
            Assert.AreEqual(2, actual.Sumar(1, 1));
            Assert.AreEqual(-1, actual.Sumar(int.MinValue, int.MaxValue));
            Assert.AreEqual(-9, actual.Sumar(-10, 1));
            Assert.AreEqual(-20, actual.Sumar(-10, -10));
        }
        
    }

    [Test]
    public void MultiplicarTest()
    {
        // lo que hacemos en un test case
        //Assert.AreNotEqual(3, m.Multiplicar(2, 2));
        
        foreach(Matematicas actual in arregloMatematicas){

            Debug.Log(actual.gameObject.transform.name);

            // incluye TODAS las opciones que se te ocurran!
            Assert.AreEqual(1, actual.Multiplicar(1, 1));
            Assert.AreEqual(0, actual.Multiplicar(10, 0));
            Assert.AreEqual(-10, actual.Multiplicar(-10, 1));
            Assert.AreEqual(100, actual.Multiplicar(-10, -10));
        }
    }
    
    [Test]
    public void DividirTest() {

        //Assert.AreEqual(12.0, m.Dividir(24, 2));

        foreach(Matematicas actual in arregloMatematicas){

            Debug.Log(actual.gameObject.transform.name);

            // incluye TODAS las opciones que se te ocurran!
            Assert.AreEqual(1, actual.Dividir(1, 1));
            Assert.AreEqual(-10, actual.Dividir(-10, 1));
            Assert.AreEqual(1, actual.Dividir(-10, -10));
        }
    }
}
