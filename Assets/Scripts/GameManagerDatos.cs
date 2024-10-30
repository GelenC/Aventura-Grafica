using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
        jugador.nombre = nombreInput.text;
        jugador.profesion = profesionDrop.options[profesionDrop.value].text;
       /* jugador.nombre = "Pablo";
        jugador.profesion = "Policía";*/
        GuardarDatos.guardar(jugador);
    }

    //Sacar los datos del Json
    public void LoadGame()
    {
        jugador = GuardarDatos.cargar();
    }


    //METODOS PARA LOS BOTONES
    public void Nombre(Text nombre) {
        nombre.text = jugador.nombre;
    }
    public void Profesion(Text profesion)
    {
        profesion.text = jugador.profesion;
        guardar.SetActive(false);
        regresar.SetActive(true);
        avanzar.SetActive(true);
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

