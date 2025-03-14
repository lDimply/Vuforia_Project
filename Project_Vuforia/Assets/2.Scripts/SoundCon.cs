using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCon : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btnName;

    // Use this for initialization
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "Boton1":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        break;
                    case "Boton2":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "Boton3":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "Boton4":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "Boton5":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "Boton6":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }

    }
}