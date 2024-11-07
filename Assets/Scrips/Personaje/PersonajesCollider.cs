using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajesCollider : MonoBehaviour
{
    public bool coleccionable= false;
    public  bool vacio = false;
    [SerializeField] Personaje personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
             coleccionable = true;
            Destroy(other.gameObject);
           // puntuacion += 1;


        }
        //if (other.CompareTag("Enemigo") || other.CompareTag("Rolling"))
        //{
        //    personaje.Vida -= 1;
        //    if (personaje.Vida < 0)
        //    {
        //        personaje.Vida = 0;
        //    }


            //animator.SetBool("golpe", true);


        //}
        if (other.CompareTag("Vacio"))
        {
            vacio = true;   
            //transform.position = inicio;
            //vida -= 1;
        }
        vacio = false;
        coleccionable=false;
        vacio=false;
        //if (other.CompareTag("Suelo"))
        //{

        //    saltoSuelo = true;

        //}

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo") || collision.gameObject.CompareTag("Rolling")) 
        {
            Debug.Log("MenosVida");
            personaje.Vida -= 1;
            if (personaje.Vida < 0)
            {
                personaje.Vida = 0;
            }
        }
    }
}
