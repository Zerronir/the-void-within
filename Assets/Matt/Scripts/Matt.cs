using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Matt : MonoBehaviour {   

    // Variables de inicio
    public int health = 500;
    public int strenght = 70;
    public int deffense = 50;
    public int magicDamage = 50;
    public int magicDeffense = 50;
    public int magicMana = 50;

    private Animator anim;
    private float x, y;
    public bool moving;
    public float movingSpeed = 50;


    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(movingSpeed * Time.deltaTime, 0));
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, movingSpeed * Time.deltaTime));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-movingSpeed * Time.deltaTime, 0));
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -movingSpeed * Time.deltaTime));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

    }

    void DeathAnimation(){
        gameObject.GetComponent<Animator>().SetBool("playerDeath", true);
        //SceneManager.LoadScene("death");
    }

    

}
