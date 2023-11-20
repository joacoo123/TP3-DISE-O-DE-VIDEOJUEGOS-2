using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI miTexto1;

    [SerializeField] TextMeshProUGUI miTexto2;





    public void ActualizarTextoHUD(string nuevoTexto)
    {

        miTexto1.text =  nuevoTexto;
        
    }

    public void ActualizarTiempoHUD(string nuevoTiempo)
    {
        miTexto2.text = "Tiempo " + nuevoTiempo;
    }

}
