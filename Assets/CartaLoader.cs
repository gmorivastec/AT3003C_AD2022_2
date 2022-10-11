using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartaLoader : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer renderer;
    
    [SerializeField]
    private TMP_Text texto;


     // DE AQUI PARA ABAJO DEBERÍA SER SUSTITUIDO POR SCRIPTABLE OBJECT
    [SerializeField]
    private Sprite sprite;

    [SerializeField]
    private string spriteLocation;

    [SerializeField]
    private float ataque;

    // Start is called before the first frame update
    void Start()
    {
        // 2 maneras de cargar sprite
        // 1- con Resources.Load
        Sprite spriteArchivo = Resources.Load<Sprite>(spriteLocation);

        // 2da opcion - usa el argumento que ya recibiste
        renderer.sprite = sprite;
        texto.text = ataque + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
