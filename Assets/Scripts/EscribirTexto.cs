using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribirTexto : MonoBehaviour
{
    public Text nombre;
    public Text textoconnombre;

    public GameObject formulario;
    public GameObject dialogoG1;
    public GameObject dialogoG2;
    public GameObject dialogoG3;

    public GameObject dialogoG4_1;
    public GameObject dialogoG4_2;
    public GameObject dialogoG4_3;
    public GameObject dialogoG4_4;
    public GameObject dialogoG4_OpcionB;
    public GameObject dialogoG5;
    public GameObject dialogoG6;
    public GameObject dialogoG7;

    public GameObject dialogoJ1;
    public GameObject dialogoJ2Opciones;
    public GameObject dialogoJ3;
    public GameObject dialogoJ4;

    public InputField nombreInput;
    public Dropdown profesionDrop;
    public GameObject validacionmensaje;


    void Start()
    {
    }
    public void _1CambiarDialogoG1_J1() {
          dialogoG1.SetActive(false);
          dialogoJ1.SetActive(true);
    }
    public void _2CambiarDialogoJ1_G2()
      {
          dialogoJ1.SetActive(false);
          dialogoG2.SetActive(true);
    }
   
    //Se identifica
    public void ActivarFormulario() {
        dialogoG2.SetActive(false);
        formulario.SetActive(true);
    }
    public void ActivarDatosJugador(GameObject panelJugador) {     
        if (!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0)
        {
            panelJugador.SetActive(true);
        }
    }

    //Vuelve a la conversación.
    public void _3CambiaDialogoForm_G3() {
        if (!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0)
        {
            textoconnombre.text = "Bueno " + nombre.text + " por si no sabías, la casa ha estado custodiada desde hace un tiempo... " +
           "\r\nLuego de una serie de incidentes, la poca familia que aún la habitaba se mudó muy lejos...";
            formulario.SetActive(false);
            dialogoG3.SetActive(true);
            validacionmensaje.SetActive(false);
        }
        else { 
        validacionmensaje.SetActive(true);
        }
       
    }

    public void _4CambiarDialogoG3OpcionA() { 
        dialogoJ2Opciones.SetActive(true);
        dialogoG3.SetActive(false);
    }

    //OPCION B

    public void opcionbdialogounico()
    {
        dialogoJ2Opciones.SetActive(false);
        dialogoG4_OpcionB.SetActive(true);
    }
    public void opcionbdialogoJUgador()
    {
        dialogoG4_OpcionB.SetActive(false);
        dialogoJ3.SetActive(true);
    }

    //Repetir opcion A.

    //OPCION A

    public void opcionAdialogo1() {
        dialogoJ2Opciones.SetActive(false);
        dialogoJ3.SetActive(false);
        dialogoG4_1.SetActive(true);
    }
    public void opcionAdialogo2()
    {
        dialogoG4_1.SetActive(false);
        dialogoG4_2.SetActive(true);
    }

    public void opcionAdialogo3()
    {
        dialogoG4_2.SetActive(false);
        dialogoG4_3.SetActive(true);
    }
    public void opcionAdialogo4()
    {
        dialogoG4_3.SetActive(false);
        dialogoG4_4.SetActive(true);
    }
    public void _5CambiarDialogoOpcionAfinal_G5() {
        dialogoG4_4.SetActive(false);
        dialogoG5.SetActive(true);
    }
    public void _6CambiarDialogoG5_j4()
    {
        dialogoG5.SetActive(false);
        dialogoJ4.SetActive(true);
    }
    public void _7CambiarDialogoj4_G6()
    {
        dialogoJ4.SetActive(false);
        dialogoG6.SetActive(true);
    }
    public void _8CambiarDialogoG6_G7()
    {
        dialogoG6.SetActive(false);
        dialogoG7.SetActive(true);
    }

   

}
