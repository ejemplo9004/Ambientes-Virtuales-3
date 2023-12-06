using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class EfectoBoton : MonoBehaviour
{
    public float cambioEscala;
    public bool tieneMalla = true;
    [ConditionalHide("tieneMalla", true)]
    public Material materialNormal;
    [ConditionalHide("tieneMalla", true)]
    public Material materialActivo;
    public AudioClip audioSobre;
    public AudioClip audioPresion;
    Vector3 escalaInicial;
    Vector3 escalaFinal;
    AudioSource sonido;
    [ConditionalHide("tieneMalla", true)]
    public MeshRenderer malla;
    public InputActionProperty triggerControl;
    public bool mouseSobre;
    public UnityEvent eventoActivar;
    bool presionado;
    public bool actibable;
    [ConditionalHide("actibable", true)]
    public KeyCode codigo;

    public bool tieneImagen;
    [ConditionalHide("tieneImagen", true)]
    public Image imagen;
    [ConditionalHide("tieneImagen", true)]
    public Sprite imNormal;
    [ConditionalHide("tieneImagen", true)]
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
            if (tieneMalla) malla.material = materialActivo;
        }
        else
        {
            if (tieneMalla) malla.material = materialNormal;
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
