using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioPersonajes : MonoBehaviour
{

    public List<Personaje> personajes;

    GameObject managerConversacion;
    HandlerConversacion handlerConv;

    [SerializeField] int indexPersonaje;

    GameObject imagenPersonaje;
    Image imgP;

    // Start is called before the first frame update
    void Start()
    {       
        managerConversacion = GameObject.Find("ManagerConversacion");
        handlerConv = managerConversacion.GetComponent<HandlerConversacion>();

        imgP = GameObject.Find("ImagenPersonaje").GetComponent<Image>();

        //
        indexPersonaje = 0;
        imgP.sprite = personajes[indexPersonaje].imagen;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (handlerConv.estadoPanel)
            {                
                imgP.sprite = personajes[++indexPersonaje].imagen;
            }
        }
    }
}
