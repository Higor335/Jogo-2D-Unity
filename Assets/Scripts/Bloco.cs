using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {
    private Rigidbody2D rb2d;
    private BoxCollider2D colisor;
    private bool colisaoComBola = false; // Variável para rastrear se houve colisão com a bola

    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        colisor = GetComponent<BoxCollider2D>();
    }

    // Chamado quando ocorre uma colisão
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("bola") || collision.gameObject.CompareTag("plataforma")) {
            Physics2D.IgnoreCollision(colisor, collision.collider, true);
            rb2d.constraints = RigidbodyConstraints2D.None;
            
            // Desativar colisão com objetos que têm as Tags "bola" e "plataforma"
        }
    }
}
