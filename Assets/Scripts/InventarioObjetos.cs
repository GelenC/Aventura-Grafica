using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioObjetos : MonoBehaviour
{
    public GameObject ultimoMensaje;
    public GameObject ActivarSiguiente;
    public Button btninventario;
    public GameObject panelInventario;
    public List<GameObject> objetos;

    /*
       void Start()
       {
       }

       void Update()
       {

       }*/

    public void AbrirInventario()
    {
        if (!panelInventario.activeSelf)
        {
            panelInventario.SetActive(true);
        }
        else
        {
            panelInventario.SetActive(false);
        }
    }

    public void ActivarItem(GameObject item) {
        if (item.tag=="rana") {
            objetos[0].SetActive(true);
            Destroy(item);
        }
        if (item.tag == "granizo"){
           objetos[1].SetActive(true);
            Destroy(item);
        }
        if (item.tag == "sangre"){
            objetos[2].SetActive(true);
            Destroy(item);
        }
        if (item.tag == "mosca") {
            objetos[3].SetActive(true);
            Destroy(item);
        }
        if (item.tag == "piojo"){
            objetos[4].SetActive(true);
            Destroy(item);
        }if (item.tag == "langosta"){
            objetos[5].SetActive(true);
            Destroy(item);
        }
        int objetosActivos=0;
        for (int i = 0; i < objetos.Count; i++) {
            if (objetos[i].activeSelf == true) {
                objetosActivos++;
            }
        }
        if (objetosActivos == 7) { 
            ultimoMensaje.SetActive(true);
            ActivarSiguiente.SetActive(true);
        }
    }
}
