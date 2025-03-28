using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Animations;
using Unity.VisualScripting;

public class ActivarCave : MonoBehaviour
{
    public GameObject Cave;
    public GameObject Boton;
    public GameObject BotonNext1992A2012;
    public GameObject BotonNext2012A2014;
    public GameObject BotonNext2014A2019;

    private bool FirstIsActive;
    private bool SecondIsActive;
    private bool ThirdIsActive;

    public VideoClip[] Video00;
    public VideoClip[] Video01;
    public VideoClip[] Video02;
    public VideoClip[] Video03;

    public VideoPlayer[] VideoPlayer;

    public GameObject[] canva;

    public void Start()
    {
        Cave.SetActive(false);
        Boton.SetActive(false);
        BotonNext1992A2012.SetActive(false);
    }
    public void ACTIVAR_BOTON()
    {
        if (!FirstIsActive)
        {
            Boton.SetActive(true);
            FirstIsActive = true;
        }
    }

    public void DESACTIVAR_BOTON()
    {
        Boton.SetActive(false);
    }

    public void ACTIVAR_CAVE()
    {
        Cave.SetActive(true);
        canva[0].SetActive(true);
        canva[1].SetActive(false);
        canva[2].SetActive(false);
        canva[3].SetActive(false);
        BotonNext1992A2012.SetActive(true);
    }

    public void CAMBIARVIDEO1993A2012()
    {
            VideoPlayer[0].clip = Video01[0];
            VideoPlayer[1].clip = Video01[1];
            VideoPlayer[2].clip = Video01[2];
            BotonNext1992A2012.SetActive(false);
            BotonNext2012A2014.SetActive(true);
            BotonNext2014A2019.SetActive(false);
            FirstIsActive = false;
            SecondIsActive = true;
            ThirdIsActive = false;
            canva[0].SetActive(false);
            canva[1].SetActive(true);
            canva[2].SetActive(false);
            canva[3].SetActive(false);
    }

    public void CAMBIARVIDEO2012A2014()
    {
            VideoPlayer[0].clip = Video02[0];
            VideoPlayer[1].clip = Video02[1];
            VideoPlayer[2].clip = Video02[2];
            BotonNext1992A2012.SetActive(false);
            BotonNext2012A2014.SetActive(false);
            BotonNext2014A2019.SetActive(true);
            FirstIsActive =false;
            SecondIsActive = false;
            ThirdIsActive = true;
            canva[0].SetActive(false);
            canva[1].SetActive(false);
            canva[2].SetActive(true);
            canva[3].SetActive(false);
    }

    public void CAMBIARVIDEO2014A2019()
    {
            VideoPlayer[0].clip = Video03[0];
            VideoPlayer[1].clip = Video03[1];
            VideoPlayer[2].clip = Video03[2];
            BotonNext1992A2012.SetActive(false);
            BotonNext2012A2014.SetActive(false);
            BotonNext2014A2019.SetActive(false);
            FirstIsActive = false;
            SecondIsActive = false;
            ThirdIsActive = false;
            canva[0].SetActive(false);
            canva[1].SetActive(false);
            canva[2].SetActive(false);
            canva[3].SetActive(true);
    }
}
