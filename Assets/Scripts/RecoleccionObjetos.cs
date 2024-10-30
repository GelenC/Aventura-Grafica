using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

public class RecoleccionObjetos : MonoBehaviour, IPointerClickHandler
{
    public InventarioObjetos inventarioOb;
    public void OnPointerClick(PointerEventData eventData)
    {
        inventarioOb.ActivarItem(gameObject);
    }
   
}
