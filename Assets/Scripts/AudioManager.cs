using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource SpotiCoin;
    void Start()
    {
        
    }
    public void ReproducirSonido(AudioClip clip)
    {
        //Ejecuta el clip introducido por parametros de entrada
        SpotiCoin.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
