using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazPreguntas : MonoBehaviour
{
    public GameObject[] entrada;
    public GameObject[] salida;
    bool Paso = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            Accion();
        }
    }

    public void Accion() 
    {
        StartCoroutine("TiempoCd");
    }
    public IEnumerator TiempoCd() 
    {

        for (int i = 0; i < salida.Length; i++)
        {
            yield return new WaitForSeconds(0.2f);
            salida[i].gameObject.SetActive(Paso);
        }
        yield return new WaitForSeconds(0.5f);
        Paso = true;
        for (int i = 0; i < entrada.Length; i++)
        {
            yield return new WaitForSeconds(0.2f);
            entrada[i].gameObject.SetActive(Paso);
        }
        yield return new WaitForSeconds(0.5f);
        Paso = false;
    }
}
