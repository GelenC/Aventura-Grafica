using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoMensajes : MonoBehaviour
{
    public GameObject panelBloqueo;
    void Start()
    {
        panelBloqueo.SetActive(true);
    }
  /*  La función para desc¡activar el bloqueo esta en el script del game manager
   *  public void DesactivarBloqueo()
    {
        panelBloqueo.SetActive(false);
    }*/
}
