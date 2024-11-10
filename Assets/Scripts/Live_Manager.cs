using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Live_Manager : MonoBehaviour
{
    public int vidas = 3;
    private int Actual;
    [SerializeField] TMP_Text VidaText;

    // Start is called before the first frame update
    void Start()
    {
        Actual = vidas;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
