using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioObjetos : MonoBehaviour
{
    private GameObject espejoImagen;
    public GameObject MRana;
    public GameObject MPiojo;
    public GameObject MLangosta;
    public GameObject MSangre;
    public GameObject MMosca;
    private GameObject botonEspejo;
    private GameObject espejo;
    public GameObject ultimoMensaje;
    public GameObject ActivarSiguiente;
    public Button btninventario;
    public GameObject panelInventario;
    public List<GameObject> objetos;
    public List<GameObject> objetosMuestra;

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
            objetosMuestra[0].SetActive(false);
            MRana.SetActive(true);
            Destroy(item);  
        }
        if (item.tag == "granizo"){
           objetos[1].SetActive(true);
            objetosMuestra[1].SetActive(false);
            Destroy(item);
        }
        if (item.tag == "sangre"){
            objetos[2].SetActive(true);
            objetosMuestra[2].SetActive(false);
            MSangre.SetActive(true);
            Destroy(item);
        }
        if (item.tag == "mosca") {
            objetos[3].SetActive(true);
            objetosMuestra[3].SetActive(false);
            MMosca.SetActive(true);
            Destroy(item);
        }
        if (item.tag == "piojo"){
            objetos[4].SetActive(true);
            objetosMuestra[4].SetActive(false);
            MPiojo.SetActive(true);
            Destroy(item);

            espejoImagen = GameObject.Find("relucir");
            Destroy(espejoImagen);
            StartCoroutine(esperarEspejo(2));
           

        }if (item.tag == "langosta"){
            objetos[5].SetActive(true);
            objetosMuestra[5].SetActive(false);
            MLangosta.SetActive(true);
            Destroy(item);

        }if (item.tag =="vacap"){
            objetos[6].SetActive(true);
            objetosMuestra[6].SetActive(false);
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

    private IEnumerator esperarEspejo(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        espejo = GameObject.Find("Canvas-Espejo");
        espejo.SetActive(false);

        botonEspejo = GameObject.Find("espejotocar");
        Destroy(botonEspejo);
    }
}
