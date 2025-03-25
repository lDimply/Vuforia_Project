using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ActivarCave : MonoBehaviour
{
    public GameObject Cave;
    public GameObject Boton;
    public GameObject BotonNext;
    private bool CaveisActive;

    public VideoClip[] Video00;
    public VideoClip[] Video01;
    public VideoClip[] Video02;

    public VideoPlayer[] VideoPlayer;

    public void Start()
    {
        Cave.SetActive(false);
        Boton.SetActive(false);
        BotonNext.SetActive(false);
    }
    public void ACTIVAR_BOTON()
    {
        if (!CaveisActive)
        {
            Boton.SetActive(true);
            CaveisActive = true;
        }
    }

    public void DESACTIVAR_BOTON()
    {
        Boton.SetActive(false);
    }

    public void ACTIVAR_CAVE()
    {
        Cave.SetActive(true);
        BotonNext.SetActive(true);
    }

    public void CAMBIARVIDEO()
    {
        if (CaveisActive)
        {
            VideoPlayer[0].clip = Video01[0];
            VideoPlayer[1].clip = Video01[1];
            VideoPlayer[2].clip = Video01[2];
        }
    }
}
