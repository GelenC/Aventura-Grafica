using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFinal : MonoBehaviour
{
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
            if (transform.position.x <= 500) { detener = true; }
        }
        
    }

    IEnumerator EsperarUnTiempo(float tiempo) {
        yield return new WaitForSeconds(tiempo);
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        detener = false;
    }

   
}
