using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]
    private float velocidad;
    
    private float moverHorizontal;
    private float moverVertical;
    private Vector3 direccionX;
    private Vector3 direccionY;
  

   


   


    private void Update()
    {
        moverHorizontal = Input.GetAxis("Horizontal");
        moverVertical = Input.GetAxis("Vertical");
        direccionX = new Vector3(moverHorizontal, moverVertical, 0f) * velocidad * Time.deltaTime;
      
            transform.Translate(direccionX);
        
    }




}