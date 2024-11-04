using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;


public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    private float h;
    private float v;
    CharacterController controller;
    private Vector3 movimiento;
    [SerializeField] float smoothTime;
    [SerializeField] float velocidadRotacion;
    float anguloSuave;

    private int puntuacion = 0;
    private Vector3 inicio;
    private int vida = 4;


    [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text life;
    Animator animator;



    [Header("Detección de Suelo")]
    [SerializeField] private float radioDeteccion;
    [SerializeField] private Transform pies;
    [SerializeField] private LayerMask queEsSuelo;

    [SerializeField] private Vector3 movVertical;
    [SerializeField] private float factorGravedad;
    [SerializeField] private float alturaSalto;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AplicarGravedad();
        MoverRotar();
        EnSuelo();
        Saltar();
        Animaciones();
        life.SetText("<3: " + vida);
        score.SetText("Score: " + puntuacion);
    }
    private void MoverRotar()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        movimiento = new Vector2(h, v).normalized;



        // float anguloRotacion= Mathf.Atan2(movimiento.x, movimiento.z)*  Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y; //rotar el objeto para que siga los ejes de la cámara. Se usa trigonometría

        if (movimiento.magnitude > 0)
        {
            //Calculo el águlo al que ponerse en funcionamiento

            float anguloRotacion = Mathf.Atan2(movimiento.x, movimiento.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

            anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloRotacion, ref velocidadRotacion, smoothTime);

            transform.eulerAngles = new Vector3(0, anguloRotacion, 0);

            Vector3 mov = Quaternion.Euler(0, anguloSuave, 0) * Vector3.forward;

            controller.Move(mov * velocidadMovimiento * Time.deltaTime); //No va por físicas así que se usa con tiempo


        }

    }
    private void AplicarGravedad()
    {
        movVertical.y += factorGravedad * Time.deltaTime;
        controller.Move(movVertical * Time.deltaTime);
    }
    private void Saltar()
    {
        //saltar la cantidad que quieras
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movVertical.y = Mathf.Sqrt(-2 * factorGravedad * alturaSalto);
        }
    }
    private bool EnSuelo()
    {
        //Tirar una esfera de detección en los piescon cierto radio
        bool resultado = Physics.CheckSphere(pies.position, radioDeteccion, queEsSuelo);
        return resultado;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntuacion += 1;
            

        }
        if (other.CompareTag("Enemigo") || other.CompareTag("Rolling"))
        {
            vida -= 1;
            if (vida < 0)
            {
                vida = 0;
            }

            
            //animator.SetBool("golpe", true);


        }
        if (other.CompareTag("Vacio"))
        {
            transform.position = inicio;
            vida -= 1;
        }

        //if (other.CompareTag("Suelo"))
        //{

        //    saltoSuelo = true;

        //}

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

        if (movimiento.magnitude > 0)
        {
            
                animator.SetBool("movimiento", true);


          
        }

           
    }
}
