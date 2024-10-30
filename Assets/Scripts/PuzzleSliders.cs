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
        position.Add(0.45f);
        position.Add(0.93f);
        position.Add(0.19f);
        position.Add(0.19f);
        position.Add(0.73f);
        position.Add(0.93f);
        position.Add(0.73f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!terminado) {
            if (sliders[0].value >= position[0] && sliders[0].value <= (position[0] + 0.07) &&
            sliders[1].value >= position[1] && sliders[1].value <= (position[1] + 0.07) &&
            sliders[2].value >= position[2] && sliders[2].value <= (position[2] + 0.07) &&
            sliders[3].value >= position[3] && sliders[3].value <= (position[3] + 0.07) &&
            sliders[4].value >= position[4] && sliders[4].value <= (position[4] + 0.07) &&
            sliders[5].value >= position[5] && sliders[5].value <= (position[5] + 0.07) &&
            sliders[6].value >= position[6] && sliders[6].value <= (position[6] + 0.07))
            {

                Debug.Log("TERMINADO");
                terminado = true;
                textoFin.SetActive(true);
                EscenaFinal.SetActive(true);
                CerrarPuzzle(gameObject);

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
}
