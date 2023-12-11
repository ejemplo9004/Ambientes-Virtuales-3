using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazPreguntas : MonoBehaviour
{
    public GameObject[] entrada;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarEntrada()
    {
        for (int i = 0; i < entrada.Length; i++)
        {
            entrada[i].gameObject.SetActive(true);
        }
        
    }
    public void ActivarSalida()
    {
        for (int i = 0; i < entrada.Length; i++)
        {
            entrada[i].gameObject.SetActive(false);
        }

    }
}
