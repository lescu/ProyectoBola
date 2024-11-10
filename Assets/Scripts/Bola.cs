using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Bola : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] int vida;
    [SerializeField] TMP_Text textoScore;
    [SerializeField] TMP_Text textoVida;

    public Vector3 posicionInicial = new Vector3 (0, 0 , 0);

    
    Rigidbody rb;
    Vector3 mover;
    float fuerzaMover = 10f;
    float fuerzaSALT = 10f;
   
    float h;
    float v;
    
    
    [SerializeField] AudioClip Moneda;
    [SerializeField] AudioManager Audio;
    

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       rb.position = posicionInicial;
        
    }

    // Update is called once per frame
    void Update()
    {
       h = Input.GetAxis("Horizontal"); // h = 1 (D ó ->) h = -1 (A ó <-), h = 0 (NADA)
        v = Input.GetAxis("Vertical"); // v = 1 (w ó ->) v = -1 (s ó v), v = 0 (NADA)

        Saltar();
    }

    private void FixedUpdate()
    {
        //Movimiento
        rb.AddForce(new Vector3(h, 0, v).normalized * fuerzaMover, ForceMode.Force);



        //Salto
        Vector3 mover = new Vector3(h, 0, v);
    }
    private void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && TocoSuelo())
        {
            rb.AddForce(Vector3.up * fuerzaSALT, ForceMode.Impulse);
        }
    }

    private bool TocoSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), 1.05f);
        return resultado;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coleccionable"))
        {
            Audio.ReproducirSonido(Moneda);
            Destroy(other.gameObject);
            score += 10;
            Debug.Log(score);
        }
        
        else if (other.gameObject.CompareTag("Respawn"))
        {
            rb.position = posicionInicial;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        else if (other.gameObject.CompareTag("Dañino"))
        {
            vida -= 1;
            Debug.Log(score);
        }
            textoVida.SetText("Life " + vida);
            textoScore.SetText("Score " + score);
    }
    
}
