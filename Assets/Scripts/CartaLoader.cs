using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartaLoader : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    
    [SerializeField]
    private TMP_Text ataque;

    [SerializeField]
    private TMP_Text defensa;
    
    [SerializeField]
    private TMP_Text nombre;


     // DE AQUI PARA ABAJO DEBERÍA SER SUSTITUIDO POR SCRIPTABLE OBJECT
    [SerializeField]
    public CartaScriptableObject data;

    // Start is called before the first frame update
    void Start()
    {

        /*
        // 2 maneras de cargar sprite
        // 1- con Resources.Load
        Sprite spriteArchivo = Resources.Load<Sprite>(spriteLocation);

        // 2da opcion - usa el argumento que ya recibiste
        spriteRenderer.sprite = sprite;
        texto.text = ataque + "";*/

        ataque.text = data.ataque + "";
        defensa.text = data.defensa + "";
        nombre.text = data.nombre;
        
        spriteRenderer.sprite = data.ilustracion;

        // en cuestión de assets lo más correcto sería asegurar un placeholder del mismo tamaño 
        // que todas las ilustraciones

        // ESTO ES UN HACK.
        spriteRenderer.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
