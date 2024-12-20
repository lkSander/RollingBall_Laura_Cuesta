using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject canvaParedNo;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float alturaSalto;
    [SerializeField] private float rayoSuelo;
    [SerializeField] private BoxCollider paredAtravesable;
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text life;
    [SerializeField] TMP_Text noMuro;
    private float h;
    private float v;
    [SerializeField] private int puntuacion;
    private Vector3 inicio;
   private Vector3 checkpoint;
    private int vida= 4;

    private float timer;

    private int intentos = 3;


    [SerializeField] AudioClip sonidoRecoger;
    [SerializeField] AudioManager audioSourceSfx;

    [SerializeField] GameObject noMuroCanvas;

    [SerializeField] GameObject objetivo;

    Rigidbody rb;


    void Start()
    {
        timer += Time.deltaTime;
        rb = GetComponent<Rigidbody>();
        inicio = transform.position;
        checkpoint = transform.localPosition;
        //checkpoint = inicio;

        noMuroCanvas.SetActive(false);
       
        vida = 4;

        cam1.SetActive(true);
        cam2.SetActive(false);


        canvaParedNo.SetActive(false);
       

        if(timer>= 2f)
        {
            objetivo.SetActive(true) ;
            if(timer>=5f)
            {
                objetivo.SetActive(false) ;
            }
        }
    }


    void Update()
    {
        life.SetText("<3: " + vida);
        score.SetText("Score: " + puntuacion);
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");
        if (DetectarSuelo())
        {
            Salto();
        }

        if (puntuacion >= 5)
        {
            AtravesarPared(true);
        }
        else
        {
            AtravesarPared(false);
        }

        VidaManager();
        
    }

    private void FixedUpdate()
    {
       
        rb.AddForce (new Vector3(h, 0, v).normalized * velocidadMovimiento, ForceMode.Force);
       
    }
    void Salto()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            rb.AddForce (new Vector3(0,1,0) * alturaSalto, ForceMode.Impulse);
        }
    }
    bool DetectarSuelo()
    {
        bool suelo = Physics.Raycast(gameObject.transform.position, Vector3.down, rayoSuelo);
        return suelo;
    }

    public bool AtravesarPared(bool atravesable)
    {
        paredAtravesable.isTrigger = atravesable;
        return atravesable;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable")) 
        {
            puntuacion += 1;

            Destroy(other.gameObject);
            audioSourceSfx.ReproducirSonido(sonidoRecoger);

        }
        if (other.CompareTag("Vacio"))
        {
            transform.position = checkpoint;
        }
       
       
        if(other.CompareTag("Checkpoint"))
        {
            checkpoint= transform.position;
        }

        if (other.CompareTag("Vida"))
        {
            vida += 1;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("End"))
        {

            SceneManager.LoadScene(3);

        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            vida -= 1;
        }
        
        if(collision.gameObject.tag.Equals("Pared"))
        {
            canvaParedNo.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Pared"))
        {
            canvaParedNo.SetActive(false);
        }
    }

    void VidaManager()
    {
        if(vida<=0)
        {
            SceneManager.LoadScene(2);

        }
       
    }
}
