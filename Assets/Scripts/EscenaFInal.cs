using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class EscenaFInal : MonoBehaviour
{
    public GameObject ejecutar;
    public GameObject musica;
    public GameObject imagenRaton;
    public GameObject raton;
    // Start is called before the first frame update
    private void Start()
    {
    }
    public void restringir() {
        
        // Bloquear el cursor en el centro de la pantalla y ocultarlo
        Cursor.lockState = CursorLockMode.Locked;
            raton.SetActive(true);
        
    }
    public void EleccionLibro()
    {
        musica.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        raton.SetActive(true);
        imagenRaton.SetActive(false);
        MouseFinal mouseFinal = ejecutar.GetComponent<MouseFinal>();
        mouseFinal.mensajeFinal();
    }


}
