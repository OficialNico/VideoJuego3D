using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarPantalla : MonoBehaviour
{
    public void Cambiar(){
        SceneManager.LoadScene("SampleScene");
    }

}
