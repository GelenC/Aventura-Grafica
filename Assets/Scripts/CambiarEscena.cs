using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//AUNQUE EL SCRIP SE LLAMA CAMBIAR ESCENA, TAMBIEN SE USA PARA DESBLOQUEAR LOS PUZZLES Y PISTAS Y MOSTRAR LA INFO DEL JUGADOR.
public class CambiarEsc : MonoBehaviour
{
    public GameObject espejo;
    private Jugador jugador;
    public Text nombre;
    public Text profesion;
    void Start() {
        jugador = GuardarDatos.cargar();
        nombre.text = jugador.nombre;
        profesion.text = jugador.profesion;
    }
    public void CambiarEscena(int num) {
        SceneManager.LoadScene(num);
    }
    public void ActivarBoton(GameObject siguiente) {
        siguiente.SetActive(true);
    }
    public void DesactivarMensaje(GameObject canvas)
    {
        canvas.SetActive(false);
    }
    public void ActivarPuzzles(GameObject puzzle) { 
        puzzle.SetActive(true);
    }
    public void DesactivarPuzzles(GameObject puzzle)
    {
        puzzle.SetActive(false);
    }

    public void ActivarEspejo() { 
    espejo.SetActive(true);
    }

}
