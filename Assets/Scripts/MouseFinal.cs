using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseFinal : MonoBehaviour
{
    public bool activado;
    public GameObject musica;
    public GameObject explicacion;
    public GameObject panelfinal;
    private float speed = 500f;
    private bool detener=true;
    // Start is called before the first frame update
    void Start()
    {
        if (activado) {
            StartCoroutine(EsperarUnTiempo(1.5f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (activado) {
            if (!detener)
            {
                transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
                if (transform.position.x <= 700) { detener = true; }
            }
        }



    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == ("Libro")) {
            mensajeFinal();
            StartCoroutine(PararMouse(0.3f));
            
        }
    }

    public void mensajeFinal() {
    
        musica.SetActive(false);
        StartCoroutine(EsperarMensajeFinal(2f));
    }
    IEnumerator EsperarUnTiempo(float tiempo) {
        yield return new WaitForSeconds(tiempo);
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        detener = false;
    }
    IEnumerator PararMouse(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        detener = true;
    }
    IEnumerator EsperarMensajeFinal(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        panelfinal.SetActive(true);
        StartCoroutine(Explicacion(5.5f));
    }
    IEnumerator Explicacion(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        explicacion.SetActive(true);
        panelfinal.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
    }


}
