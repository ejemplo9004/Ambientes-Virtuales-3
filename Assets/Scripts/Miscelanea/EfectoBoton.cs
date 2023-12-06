using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

public class EfectoBoton : MonoBehaviour
{
    public float cambioEscala;
    public Material materialNormal;
    public Material materialActivo;
    public AudioClip audioSobre;
    public AudioClip audioPresion;
    Vector3 escalaInicial;
    Vector3 escalaFinal;
    AudioSource sonido;
    public MeshRenderer malla;
    public InputActionProperty triggerControl;
    public bool mouseSobre;
    public UnityEvent eventoActivar;
    bool presionado;
    public KeyCode codigo;
    public bool actibable;

    public bool tieneImagen;
    public Image imagen;
    public Sprite imNormal;
    public Sprite imActivo;



    void Start()
    {
        escalaInicial = transform.localScale;
        escalaFinal = escalaInicial * cambioEscala;
        sonido = GetComponent<AudioSource>();
		if (imagen == null)
		{
            imagen = GetComponent<Image>();
		}
        if (malla==null)
        {
            malla = GetComponent<MeshRenderer>();
        }
    }

    public void AumentarEscala(bool activo)
    {
        transform.localScale = activo ? escalaFinal : escalaInicial;
		if (tieneImagen)
		{
            imagen.sprite = activo ? imActivo : imNormal;
        }
        mouseSobre = activo;
        if (activo)
        {
            sonido.clip = audioSobre;
            sonido.Play();
            malla.material = materialActivo;
        }
        else
        {
            malla.material = materialNormal;
        }
    }

    private void Update()
    {
        if (mouseSobre)
        {
            if (triggerControl.action.ReadValue<float>()>0.8f && !presionado)
            {
                presionado = true;
                eventoActivar.Invoke();
                sonido.clip = audioPresion;
                sonido.Play();
                transform.localScale = escalaInicial;
            }
            else if (triggerControl.action.ReadValue<float>() < 0.2f && presionado)
            {
                presionado = false;
                transform.localScale = escalaFinal;
            }
        }
		if (actibable && Input.GetKeyDown(codigo))
        {
            eventoActivar.Invoke();
        }
    }
}
