using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour {

    public AudioSource audioSource;
    

    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject colisor = collision.collider.gameObject;
        GameObject.Destroy(colisor); 
        audioSource.Play();
    }

    private void OnTriggernter2D(Collider2D colisor){
        GameObject.Destroy(colisor.gameObject);
    }
}
