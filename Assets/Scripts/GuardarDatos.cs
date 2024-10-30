using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

//Clase Jugador para almacenar los atributos nombre y profesión
[System.Serializable]
public class Jugador
{
    public string nombre;
    public string profesion; 

}
public static class GuardarDatos 
{
    public static void guardar(Jugador jugador)
    {
        // Dirección de la carpeta 
        string carpeta = "GuardarDatos"; 
        string filePath = Path.Combine(Application.dataPath, carpeta, "Datosjugador.json");
        //Crear si no existe
        if (!Directory.Exists(Path.GetDirectoryName(filePath))) {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
        //Crear json
        string json = JsonUtility.ToJson(jugador);
        File.WriteAllText(filePath, json);
        Debug.Log("Datos guardados en: " + filePath);
    }

    public static Jugador cargar(){
        string carpeta = "GuardarDatos"; // Nombre de la carpeta
        string filePath = Path.Combine(Application.dataPath, carpeta, "Datosjugador.json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<Jugador>(json);
        }
        else {
            Debug.LogWarning("No se encontró archivo de datos, se usará un nuevo archivo.");
            return null;
        }
    }

}
