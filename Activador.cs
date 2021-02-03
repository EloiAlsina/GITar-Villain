using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public AudioSource audio;
    public KeyCode tecla;
    bool actiu = false;
    GameObject nota;
    void Start(){
        
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla) && actiu)
        {
            Destroy(nota);
            addPuntuacio();
            audio.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        actiu = true;
        if (collision.gameObject.tag == "Nota")
            nota = collision.gameObject;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        actiu=false;
    }

    void addPuntuacio()
    {
        PlayerPrefs.SetInt("Puntuació", PlayerPrefs.GetInt("Puntuació") + 10);
    }
}
