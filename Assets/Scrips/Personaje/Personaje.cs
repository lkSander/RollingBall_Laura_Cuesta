using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;


public class Personaje : MonoBehaviour
{

    [SerializeField] public float velocity;
    Rigidbody rb;
    Animator animator;
   [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text life;


     float h, v;
    private int puntuacion = 0;
    private Vector3 inicio;
    private int vida =3 ;
    
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        inicio= transform.position;
        life.SetText("<3: " + vida);
        score.SetText("Score: " + puntuacion);

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Animaciones();
      

    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v) * velocity, ForceMode.Force);
    }

    void Movimiento()

    {
       // rb.AddForce(direccionF * fuerza, ForceMode.TipoF);
        h= Input.GetAxisRaw("Horizontal");
       v = Input.GetAxisRaw("Vertical");

        


        ////float z = 0;
        ////float x = 0;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //z++;
        //    transform.position += new Vector3(0, 0, 1).normalized * velocity * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        //{

        //    transform.position += new Vector3(-1, 0, 1).normalized * velocity * Time.deltaTime;

        //}
        ////    x--;
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -1).normalized * velocity * Time.deltaTime;
        //    //    z--;
        //}
        //if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(1, 0, 1).normalized * velocity * Time.deltaTime;
        //    //    x++;
        //}
        ////rb.velocity = new Vector3(x * velocity, 0, z * velocity);

        ////if (Input.GetKey(KeyCode.D))
        ////{
        ////    transform.eulerAngles = new Vector3(0, 90, 0);
        ////}



    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntuacion +=10;
            score.SetText("Score: " + puntuacion);

        }
        if(other.CompareTag("Enemigo"))
        {
            vida -= 1;
            life.SetText("<3: " + vida);

        }
        if (other.CompareTag("Vacio"))
        {
            transform.position = inicio;
        }
        
    }
    void Animaciones()
    {
        //if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.D) )
        //{
        //    animator.SetBool("movimiento",true);
        //}
        //else
        //{
        //    animator.SetBool("movimiento", false);
        //}
        if (v > 0 || v < 0)
        {
            animator.SetBool("movimiento", true);
        }
        if (v == 0)
        {
            animator.SetBool("movimiento", false);
        }
    }
   
}

