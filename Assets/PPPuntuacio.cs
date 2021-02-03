using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PPPuntuacio : UnityEngine.MonoBehaviour
{
    public string puntuacio;
    void Start()
    {
    }
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(puntuacio) + "";
    }
}
