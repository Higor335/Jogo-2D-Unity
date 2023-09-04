using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour {
    public AudioSource audioSource; // Referência para o AudioSource no Inspector

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("bola")) {
            GameObject colisor = collision.collider.gameObject;
            GameObject.Destroy(colisor);
            Application.Quit();
        } else {
            StartCoroutine(DestruirColisorDepoisDeUmSegundo(collision.collider.gameObject));
        }
    }

    IEnumerator DestruirColisorDepoisDeUmSegundo(GameObject objetoParaDestruir) {
        // Tocar o som no início da função
        audioSource.Play();

        yield return new WaitForSeconds(0.5f);
        GameObject.Destroy(objetoParaDestruir); // Destruir o objeto colisor após 0.5 segundos
    }
}
