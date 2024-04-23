using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public string[] listaNumeros;

    public string referencia;

    public GameObject[] accesorios_Reloj;
    public GameObject[] accesorios_Maleta;
    public GameObject[] ropas_F;
    public GameObject[] ropas_M;
    public GameObject[] cabezas_F;
    public GameObject[] cabezas_M;
    public GameObject[] cejas_F;
    public GameObject[] cejas_M;
    public GameObject[] pelos_F;
    public GameObject[] pelos_M;
    public GameObject[] sombreros;
    public GameObject[] zapatos;

    [ContextMenu("Convertir")]
    public void Covertir() 
    {
        listaNumeros = referencia.Split("|");

        int indice = int.Parse(listaNumeros[0]);
        for (int i = 0; i < accesorios_Reloj.Length; i++)
        {
            accesorios_Reloj[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[1]);
        for (int i = 0; i < accesorios_Maleta.Length; i++)
        {
            accesorios_Maleta[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[2]);
        for (int i = 0; i < ropas_F.Length; i++)
        {
            ropas_F[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[3]);
        for (int i = 0; i < ropas_M.Length; i++)
        {
            ropas_M[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[4]);
        for (int i = 0; i < cabezas_F.Length; i++)
        {
            cabezas_F[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[5]);
        for (int i = 0; i < cabezas_M.Length; i++)
        {
            cabezas_M[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[6]);
        for (int i = 0; i < cejas_F.Length; i++)
        {
            cejas_F[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[7]);
        for (int i = 0; i < cejas_M.Length; i++)
        {
            cejas_M[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[8]);
        for (int i = 0; i < pelos_F.Length; i++)
        {
            pelos_F[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[9]);
        for (int i = 0; i < pelos_M.Length; i++)
        {
            pelos_M[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[10]);
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(indice == i);
        }
        indice = int.Parse(listaNumeros[11]);
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(indice == i);
        }   
    }
 
}
