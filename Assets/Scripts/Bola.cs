using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
    private int score;
    [SerializeField] TMP_Text textoScore;
    Vector3 mover;
    float fuerzaMover = 5f;
    float fuerzaSALT = 10f;
    Rigidbody rb;
    float h;
    float v;
    [SerializeField] AudioClip Moneda;
    [SerializeField] AudioManager Audio;
    

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaSALT, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coleccionable"))
        {
            Audio.ReproducirSonido(Moneda);
            Destroy(other.gameObject);
            score += 10;
        }
            textoScore.SetText("Score " + score);
    }
}
