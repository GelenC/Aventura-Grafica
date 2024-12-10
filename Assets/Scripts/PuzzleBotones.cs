using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PuzzleBotones : MonoBehaviour
{
    public GameObject puzzleactual;
    public GameObject mensajeFinal;
    public GameObject botonSiguienteEscena;
    public List<UnityEngine.UI.Toggle> toggles;
    public List<UnityEngine.UI.Button> botones;
    private int indicetactual;
    
    void Start()
    {
        //Desactivarlos todos al inicio
        Desactivar();
        for (int i = 0; i < botones.Count; i++) { 
            botones[i].name = i.ToString();
            int index = i;
            botones[i].onClick.AddListener(() =>revisar(index));
        }  
    }

    void revisar(int index) {
        toggles[index].isOn = true;


            if (index == indicetactual)
            {
                indicetactual++;
                if (indicetactual >= toggles.Count)
                {
                    botonSiguienteEscena.SetActive(true);
                puzzleactual.SetActive(false);mensajeFinal.SetActive(true);
                    Debug.Log("COMPLETADO");
                    
                }
            }
            else {
                Desactivar();
                indicetactual = 0;
            }
        }

    public void Desactivar() {
        for (int i = 0; i < toggles.Count; i++)
        {
            toggles[i].isOn = false;
        }
    }

}
