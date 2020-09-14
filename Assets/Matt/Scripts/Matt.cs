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

    private Rigidbody2D rb2d;

    private Animator anim;
    private float x, y;
    public bool moving;
    public float movingSpeed = 50;


    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetKey(KeyCode.D)){
             Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
             transform.position = transform.position + horizontal * Time.deltaTime;
        }

    }

    void DeathAnimation(){
        gameObject.GetComponent<Animator>().SetBool("playerDeath", true);
        //SceneManager.LoadScene("death");
    }

    

}
