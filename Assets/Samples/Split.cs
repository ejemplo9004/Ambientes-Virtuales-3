using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public string[] listaNumeros;
    public string referencia;
    public GameObject[] accesorios;
    public GameObject[] ropas;
    public GameObject[] cabezas;    
    public GameObject[] cejas;
    public GameObject[] pelos;
    public GameObject[] sombreros;
    public GameObject[] zapatos;

    [ContextMenu("Convertir")]
    public void Covertir() 
    {
        listaNumeros = referencia.Split("|");

        int indice = int.Parse(listaNumeros[0]);
        for (int i = 0; i < accesorios.Length; i++)
        {
            accesorios[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[1]);
        for (int i = 0; i < ropas.Length; i++)
        {
            ropas[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[2]);
        for (int i = 0; i < cabezas.Length; i++)
        {
            cabezas[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[3]);
        for (int i = 0; i < cejas.Length; i++)
        {
            cejas[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[4]);
        for (int i = 0; i < pelos.Length; i++)
        {
            pelos[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[5]);
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[6]);
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(indice == i);
        }   
    }
 
}
