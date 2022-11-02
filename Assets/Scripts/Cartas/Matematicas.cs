using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matematicas : MonoBehaviour
{

    [SerializeField]
    private Shuffler _shuffler1;
    
    [SerializeField]
    private Shuffler _shuffler2;
    
    [SerializeField]
    private Shuffler _shuffler3;

    // propiedad en C#
    // divide quién lee y quién escribe
    public Shuffler Shuffler1{
        get{
            return _shuffler1;
        }
    }
    
    public Shuffler Shuffler2{
        get{
            return _shuffler2;
        }
    }

    public Shuffler Shuffler3{
        get{
            return _shuffler3;
        }
    }

    public int Sumar(int a, int b){
        return a + b;
    }

    public int Multiplicar(int a, int b){
        return a * b;
    }

    public float Dividir(int a, int b){
        return a / b;
    }
}
