using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro_Cubos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody[] rbs;

    private float timer = 0f;
    private bool iniciarCuenta = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iniciarCuenta)
        {
            timer += 1 * Time.unscaledDeltaTime;
            if (timer > 3f)
            {
                Time.timeScale = 1f;
                iniciarCuenta = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if ( other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.05f;
            iniciarCuenta = true;
        }
    }
}
