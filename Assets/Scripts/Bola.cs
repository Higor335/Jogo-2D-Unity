using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour{

    public Vector2 velocidade;

    // Start is called before the first frame update
    void Start(){
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(velocidade);
    }
}
