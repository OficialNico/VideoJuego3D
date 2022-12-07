using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerMonedas : MonoBehaviour
{
    public Text txtMonedas;

    void Start()
    {
        txtMonedas.text=GameContoller.monedas.ToString();
    }

    void Update()
    {
        
    }
}
