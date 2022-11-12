using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuscriptorDummy : MonoBehaviour
{
    
    public void VidaSeAcabo() 
    {

        print(transform.name + ": EVENTO VIDA CERO INVOCADO");
    }

    public void EscucharEvento2(float valor){
        print(transform.name + ": EVENTO 2, valor recibido fue " + valor);
    }

    public void EscucharEvento3(string valor1, int valor2)
    {
        print(transform.name + ": EVENTO 3, valor recibido fue " + valor1 + " , " + valor2);
    }
}
