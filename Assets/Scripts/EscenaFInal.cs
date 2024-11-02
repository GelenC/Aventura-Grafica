using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EscenaFInal : MonoBehaviour
{
    public GameObject raton;
    // Start is called before the first frame update
    public void restringir() {
        
            // Bloquear el cursor en el centro de la pantalla y ocultarlo
            Cursor.lockState = CursorLockMode.Locked;
            raton.SetActive(true);
        
    }


}
