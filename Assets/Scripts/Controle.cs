using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour{

    public float horizontalAxis;
    public float velocity = 10.0f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        horizontalAxis = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontalAxis * velocity, 0);
    }
}
