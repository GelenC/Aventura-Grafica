using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPuzzle : MonoBehaviour
{
    public GameObject textoPista;
    public GameObject botonPuzzleToogles;
    Boolean resuelto = false;
    public int tamañocuadricula = 3;
    public List<Button> piezas;
    private Vector2 espacioVacio;  //Posición espacio vacio
    private int posicionVacia;  //Indice espacio vacio
    private Button botonvacio;
    //-1 ya que el index en lista empieza por 0
    void Start()
    {
        botonvacio = piezas[8];
        espacioVacio = new Vector2(tamañocuadricula - 1, tamañocuadricula- 1);
        posicionVacia = tamañocuadricula * tamañocuadricula - 1;
    }

    public void MoverPieza(Button boton)
    {
       
        int posicion = piezas.IndexOf(boton);

        if (!resuelto) {
            if (Adyacente(posicion))
            {
                Button btemporal = piezas[posicion];
                piezas[posicion] = piezas[posicionVacia];
                piezas[posicion] = btemporal;


                Vector3 temporalposicion = piezas[posicion].transform.position;
                piezas[posicion].transform.position = piezas[posicionVacia].transform.position;
                piezas[posicionVacia].transform.position = temporalposicion;

                piezas[posicionVacia] = boton;
                piezas[posicion] = botonvacio;

                posicionVacia = posicion;
                Resuelto();
            }
        }
    }

    //Verificar que esta al lado del vacio.
    private bool Adyacente(int posicion) {
        int fila = posicion / tamañocuadricula;
        int columna = posicion % tamañocuadricula;

        int filavacia = posicionVacia / tamañocuadricula;
        int columnavacia = posicionVacia % tamañocuadricula;

        //Mathf.abs en para el valor absoluto
        return ((fila == filavacia) && Mathf.Abs(columna - columnavacia) == 1) ||
            ((columna==columnavacia) && Mathf.Abs(fila-filavacia)==1);
    }

    private bool Resuelto() {

        List<Button> botones = piezas;

        if (piezas[0].gameObject.name=="Boton1" && piezas[1].gameObject.name == "Boton2" && piezas[2].gameObject.name == "Boton3" &&
            piezas[3].gameObject.name=="Boton4" && piezas[4].gameObject.name == "Boton5" && piezas[5].gameObject.name == "Boton6" &&
            piezas[6].gameObject.name=="Boton7" && piezas[7].gameObject.name == "Boton8") {
            Debug.Log("ESTA RESUELTO");
            botonPuzzleToogles.SetActive(true);
            textoPista.SetActive(true);
        }
        return true;
    }
}
