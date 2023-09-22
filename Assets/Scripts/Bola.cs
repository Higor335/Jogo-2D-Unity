using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour{

    public Vector2 velocidade;
    public float velocidadeRotacao = 5000f;

    // Start is called before the first frame update
    void Start(){
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(velocidade);

    }

    private void OnCollisionEnter2D(Collision2D collision){
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.angularVelocity = velocidadeRotacao;
    }
}
