using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{

    private Vector3 escala;
    private Vector3 dato;
    private int score;
    private int scoreString;
    private int limiteEscala;
    private float tiempoAcumulado;
    private int tiempoSegundos;


    [SerializeField]
    private UnityEvent<string> OnTextChanged;
    [SerializeField]
    private UnityEvent<string> OnTimeChanged;

    [SerializeField]
    private int sumaScore;

    [SerializeField]
    private float escalaValor;

    [SerializeField]
    private int tiempoTotal;

    // Start is called before the first frame update
    void Start()
    {
        escala = new Vector3(escalaValor, escalaValor, 0f);
        OnTimeChanged.Invoke(tiempoTotal.ToString());
        limiteEscala = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        tiempoAcumulado += deltaTime;
        tiempoSegundos = Mathf.FloorToInt(tiempoAcumulado);
        
        OnTextChanged.Invoke("Score " + score.ToString());
        if (tiempoSegundos != Mathf.FloorToInt(tiempoAcumulado - deltaTime))
        {
            tiempoTotal--;
            OnTimeChanged.Invoke(tiempoTotal.ToString());
       
        }
        if (tiempoTotal == 0)
        {
            SceneManager.LoadScene(1);
        }
        GameManager.Instance.scorE = score;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemigoSuma"))
        {
            transform.localScale += escala;
            score += sumaScore;
            limiteEscala++;
        }
        else if (collision.gameObject.CompareTag("EnemigoResta"))
        {
            if((limiteEscala >= 0))
            {
                transform.localScale -= escala * 2;
                limiteEscala--;
            }
            
            score -= sumaScore*2;
           
        }
    }

   
}
