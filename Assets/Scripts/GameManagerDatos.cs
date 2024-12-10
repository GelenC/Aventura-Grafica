using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using static UnityEngine.Rendering.DebugUI;
public class GameManagerDatos : MonoBehaviour
{
    public static GameManagerDatos instance;
    private Jugador jugador = new Jugador();
    public InputField nombreInput;
    public Dropdown profesionDrop;
    public GameObject guardar;
    public GameObject regresar;
    public GameObject avanzar;

    // Hacer que el GameManager persista entre escenas
    private void Awake(){
        if (instance == null){   
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    //Llamar al metodo guardar para convertir en Json
    public void SaveGame()
    {
        /*(!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0 para asegurase de que 
         esté elegida una opción válida*/
       
        if (!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0)
        {
            jugador.nombre = nombreInput.text;
            jugador.profesion = profesionDrop.options[profesionDrop.value].text;
            GuardarDatos.guardar(jugador);
        }
         
    }

    //Sacar los datos del Json
    public void LoadGame()
    {
        jugador = GuardarDatos.cargar();
    }


    //METODOS PARA LOS BOTONES
    public void Nombre(Text nombre) {
        if (!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0)
        {
            nombre.text = jugador.nombre;
        } 
    }
    public void Profesion(Text profesion)
    {
        if (!string.IsNullOrWhiteSpace(nombreInput.text) && profesionDrop.value != 0)
        {
            profesion.text = jugador.profesion;
        }
       
    }
    public void ActivarRegresar() { 
        guardar.SetActive(true);
        regresar.SetActive(false);
        avanzar.SetActive( false);
    }


    //Guardar datos entre Escenas
    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            SaveGame();
        }
    }


}

