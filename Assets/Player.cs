using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public int initialMaxHealth = 300;
    public int health;
    public int strength = 50;
    public float velMovimiento = 5f;
    public Rigidbody2D rb;

    // Agregamos las animaciones
    public Animator animator;
    Vector2 movimiento;
    

    // Start is called before the first frame update
    void Start() {
        health = initialMaxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movimiento * velMovimiento * Time.fixedDeltaTime);    
    }

    // Moverse hacia arriba
    void MoveUp(){
        
    }

    // Moverse hacia abajo
    void MoveDown(){}

    // Moverse hacia la derecha
    void MoveRight(){}

    // Moverse hacia la izquierda
    void MoveLeft(){}

}
