using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destruidor : MonoBehaviour {

    public AudioSource audioSource;
    public TMP_Text mensagem;

    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject colisor = collision.collider.gameObject;
        GameObject.Destroy(colisor); 
        audioSource.Play();
        mensagem.text = "Você Perdeu!";
    }

    private void OnTriggernter2D(Collider2D colisor){
        GameObject.Destroy(colisor.gameObject);
    }
}
