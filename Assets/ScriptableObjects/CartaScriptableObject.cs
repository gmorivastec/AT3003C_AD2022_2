using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="cartaNueva", menuName="ScriptableObjects/Carta", order=1)]
public class CartaScriptableObject : ScriptableObject
{
    public string nombre;
    public float ataque;
    public float defensa;
    public Sprite ilustracion;
}
