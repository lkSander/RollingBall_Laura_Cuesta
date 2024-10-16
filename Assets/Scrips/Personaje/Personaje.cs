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

    [SerializeField] float fuerzaSalto;


   private  float h, v, y;
    private int puntuacion = 0;
    private Vector3 inicio;
    private int vida =3 ;
    private bool detectarSuelo = false;
    private float maxDistance = 0.2f;
    private bool vuelta = false;
    
  

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
        detectarSuelo=DetectarSuelo(detectarSuelo);
        Salto();
      

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

        if (Input.GetKey(KeyCode.W)&& vuelta==true )
        {
            vuelta = false;
            transform.eulerAngles += new Vector3(0, 180, 0);
            //    //z++;
            //    transform.position += new Vector3(0, 0, 1).normalized * velocity * Time.deltaTime;
        }
        //if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        //{

        //    transform.position += new Vector3(-1, 0, 1).normalized * velocity * Time.deltaTime;

        //}
        ////    x--;
        if (Input.GetKey(KeyCode.S)&& vuelta==false)
        {
            transform.eulerAngles += new Vector3(0, 180, 0);
            vuelta = true;
        //    transform.position += new Vector3(0, 0, -1).normalized * velocity * Time.deltaTime;
        //    //    z--;
        }
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
        if(other.CompareTag("Enemigo")|| other.CompareTag("Rolling"))
        {
            vida -= 1;
            life.SetText("<3: " + vida);
            animator.SetBool("golpe", true);


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
    void Salto()
    {
        if(Input.GetKey(KeyCode.Space) && detectarSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            

        }
        //animator.SetBool("salto", false);
       
    }

     private bool DetectarSuelo(bool detectarSuelo)

    {

        // bool Physics.Raycast(Vector3 origin (transform.position), Vector3 direction(dirección del rayo), float maxDistance(longitud del rayo))



        detectarSuelo= Physics.Raycast(transform.position, Vector3.down, maxDistance);
        Debug.DrawRay(transform.position, Vector3.down, Color.red, 1f);  //para dibujar por ejemplo el raycast//Si lo pones bajo el return no se dibuja
        return detectarSuelo;


        

    }
   




}

