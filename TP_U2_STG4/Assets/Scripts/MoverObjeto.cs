using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MoverObjeto : MonoBehaviour
{

    [SerializeField]
    private float velocidad;
    [SerializeField]
    private float EjeX;
    [SerializeField]
    private float EjeY;

    private Vector3 direccionX;









    private void Update()
    {

        direccionX = new Vector3(EjeX, EjeY, 0f) * velocidad * Time.deltaTime;

        transform.Translate(direccionX);

    }




}