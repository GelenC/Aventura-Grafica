using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EscenaFInal : MonoBehaviour
{
    private MouseFinal ejecutar = new MouseFinal();
    public GameObject musica;
    public GameObject imagenRaton;
    public GameObject raton;
    // Start is called before the first frame update
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
        ejecutar.mensajeFinal();
    }


}
