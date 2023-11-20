using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int scoRe;

    [SerializeField]
    private UnityEvent<string> OnTextChanged;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoRe = GameManager.Instance.scorE;
        Debug.Log("Score: " + scoRe);
        OnTextChanged.Invoke("Score " + scoRe);
    }
}
