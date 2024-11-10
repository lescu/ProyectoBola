using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class C_Manager : MonoBehaviour
{
    public void empezarPartida()
    {
        //Cargo la escena que quiero
        SceneManager.LoadScene(1);
        Debug.Log("Abriendo Juego");
    }

    public void terminarJuego()
    {
        //Solo funciona con el ejecutable.
        Application.Quit();
    }
}
