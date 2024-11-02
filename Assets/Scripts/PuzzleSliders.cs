using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSliders : MonoBehaviour
{
    public GameObject textoFin;
    public GameObject EscenaFinal;
    public List<Slider> sliders;
    private List<float> position;
    private bool terminado = false;
    void Start()
    {
        position = new List<float>(7);
        position.Add(0.46f);
        position.Add(0.96f);
        position.Add(0.18f);
        position.Add(0.18f);
        position.Add(0.72f);
        position.Add(0.96f);
        position.Add(0.72f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!terminado) {
            if (sliders[0].value >= position[0] && sliders[0].value <= 0.55 &&
            sliders[1].value >= position[1] && sliders[1].value <= 1 &&
            sliders[2].value >= position[2] && sliders[2].value <= 0.25 &&
            sliders[3].value >= position[3] && sliders[3].value <= 0.25 &&
            sliders[4].value >= position[4] && sliders[4].value <= 0.80 &&
            sliders[5].value >= position[5] && sliders[5].value <= 1 &&
            sliders[6].value >= position[6] && sliders[6].value <= 80)
            {

                Debug.Log("TERMINADO");
                StartCoroutine(EsperarYAccion(1f));

            }
        }
    }

    public void AbrirPuzzle(GameObject puzzle) { 
    puzzle.SetActive(true);
    }
    public void CerrarPuzzle(GameObject puzzle)
    {
        puzzle.SetActive(false);
    }
    private IEnumerator EsperarYAccion(float segundos)
    {
        yield return new WaitForSeconds(segundos); // Esperar el tiempo especificado
        terminado = true;
        textoFin.SetActive(true);
        EscenaFinal.SetActive(true);
        CerrarPuzzle(gameObject);
    }
}
