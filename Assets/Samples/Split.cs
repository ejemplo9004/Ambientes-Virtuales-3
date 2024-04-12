using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public string[] listaNumeros;
    public string referencia;
    public GameObject[] pelos;
    public GameObject[] ropas;
    public GameObject[] zapatos;

    [ContextMenu("Convertir")]
    public void Covertir() 
    {
        listaNumeros = referencia.Split("|");

        int indice = int.Parse(listaNumeros[0]);
        for (int i = 0; i < pelos.Length; i++)
        {
            pelos[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[1]);
        for (int i = 0; i < pelos.Length; i++)
        {S
            ropas[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[2]);
        for (int i = 0; i < pelos.Length; i++)
        {
            zapatos[i].SetActive(indice == i);
        }
    }
 
}
