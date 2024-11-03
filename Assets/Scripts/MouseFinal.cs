using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseFinal : MonoBehaviour
{
    public GameObject musica;
    public GameObject Salir1;
    public GameObject Salir2;
    public GameObject Salir3;
    public GameObject explicacion;
    public GameObject panelfinal;
    private float speed = 500f;
    private bool detener=true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EsperarUnTiempo(1.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (!detener) {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            if (transform.position.x <= 700) { detener = true; }
        }



    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == ("Libro")) {
            mensajeFinal();
        }
        if (collision.gameObject.name == ("Salir"))
        {
            Salir1.SetActive(false);
            Salir2.SetActive(true);
        }
        if (collision.gameObject.name == ("Salir2"))
        {
            Salir2.SetActive(false);
            Salir3.SetActive(true);
        }
        if (collision.gameObject.name == ("Salir3"))
        {
            Salir3.SetActive(false);
            Salir1.SetActive(true);
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
