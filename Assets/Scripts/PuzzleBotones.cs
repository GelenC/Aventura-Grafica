using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PuzzleBotones : MonoBehaviour
{
    public GameObject mensajeFinal;
    public GameObject botonSiguienteEscena;
    public List<UnityEngine.UI.Toggle> toggles;
    private int indicetactual;
    void Start()
    {
        //Desactivarlos todos al inicio
        Desactivar();

        for (int i = 0; i < toggles.Count; i++) {
            //Cambiar el nombre del toggle por el indice toggle3-->1.
            toggles[i].name = i.ToString();
            toggles[i].onValueChanged.AddListener(revisar);
        }
       
    }

    void revisar(bool encendido) {
        int indice = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        if (encendido) {
            if (indice == indicetactual)
            {
                indicetactual++;
                if (indicetactual >= toggles.Count)
                {
                    botonSiguienteEscena.SetActive(true);
                    mensajeFinal.SetActive(true);
                    Debug.Log("COMPLETADO");
                }
            }
            else {
                Desactivar();
                indicetactual = 0;
            }
        }
    }

    public void Desactivar() {
        for (int i = 0; i < toggles.Count; i++)
        {
            toggles[i].isOn = false;
        }
    }

    public void ActivarToggle(UnityEngine.UI.Toggle toggle) {
        //toggle.isOn = !toggle.isOn;
    }
    void Update()
    {
        
    }
}
