using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    public static short monedas;

    void Awake(){
        DontDestroyOnLoad(gameObject);
    }
}
